using DesafioDaVenda.Data;
using DesafioDaVenda.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioDaVenda
{
    public partial class FrmVenda : Form
    {
        public static int clienteId;
        AppDbContext _context = new AppDbContext();
        private Venda venda;

        public FrmVenda()
        {
            InitializeComponent();
            // Iniciando a venda
            CriarVenda();
        }

        /// <summary>
        /// Adicionando um produto no itemVenda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                // Pesquisando no banco o código do produto
                Produto produto = _context.Produtos.FirstOrDefault(pd =>
                                    pd.CodigoEan == tbCodigo.Text);

                // Verificando se já não existe um produto no ItemVenda
                ItemVenda verificaItem = _context.ItensVenda.Where(iv => iv.VendaId == venda.Id)
                                    .FirstOrDefault(iv => iv.ProdutoId == produto.Id);

                if (verificaItem == null)
                {
                    // Verificando se tem o produto em estoque
                    if (produto.Estoque >= int.Parse(tbQtd.Text)) 
                    {
                        ItemVenda itemVenda = new ItemVenda(venda.Id, produto.Id,
                            int.Parse(tbQtd.Text), produto.Preco * double.Parse(tbQtd.Text));

                        produto.Estoque -= int.Parse(tbQtd.Text);

                        _context.Produtos.Update(produto);
                        _context.ItensVenda.Add(itemVenda);
                        _context.SaveChanges();

                        venda.ValorTotal += itemVenda.ValorTotal;
                        
                        CarregarDados();
                        LimparCampos();
                    }
                    else
                    {
                        MessageBox.Show("Estoque insuficiente", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Produto já está na lista", "Conflito",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } 
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao adicionar " + erro.Message, "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Finalizando a venda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            // Atualizando a venda criada no início do form
            _context.Vendas.Update(venda);
            _context.SaveChanges();

            FrmMenu frm = new FrmMenu();
            frm.Show();
            this.Close();
        }

        /// <summary>
        /// Removendo o produto do listView e do banco 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                // Pegando o produto do banco
                Produto produto = _context.Produtos.FirstOrDefault(pd =>
                        pd.CodigoEan == tbCodigo.Text);

                // Pegando o itemVenda
                ItemVenda item = _context.ItensVenda
                    .FirstOrDefault(it => it.VendaId == venda.Id); 

                produto.Estoque += item.Quantidade;
                venda.ValorTotal -= item.ValorTotal;

                _context.Produtos.Update(produto);
                _context.ItensVenda.Remove(item);
                _context.SaveChanges();

                LimparCampos();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao deletar" + erro, "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CarregarDados();
        }

        /// <summary>
        /// Método que cria a venda ao iniciar para obter seu id
        /// </summary>
        private void CriarVenda()
        {
            venda = new Venda(clienteId, 0);
            _context.Vendas.Add(venda);
            _context.SaveChanges();

            // Método que pega a venda em ordem decrescente, pelo último id
            venda = _context.Vendas.OrderByDescending(v => v.Id).FirstOrDefault();
        }

        /// <summary>
        /// Método para carregar dados na interface do listView
        /// </summary>
        private void CarregarDados()
        {
            try
            {
                // Pesquisando no banco os itens venda atráves da vendaId
                List<ItemVenda> itensVenda = _context.ItensVenda.Where(v => v.VendaId == venda.Id).ToList();
                int contador = 0;

                lvVenda.Items.Clear();

                // Populando o listView com os produtos no itensVenda
                foreach(ItemVenda item in itensVenda)
                {
                    Produto produto = _context.Produtos.FirstOrDefault(pd => pd.Id == item.ProdutoId);
                    lvVenda.Items.Add(item.ProdutoId.ToString());
                    lvVenda.Items[contador].SubItems.Add(produto.CodigoEan);
                    lvVenda.Items[contador].SubItems.Add(produto.Nome);
                    lvVenda.Items[contador].SubItems.Add(item.Quantidade.ToString());
                    lvVenda.Items[contador].SubItems.Add(produto.Preco.ToString());
                    lvVenda.Items[contador].SubItems.Add(item.ValorTotal.ToString());

                    contador++;
                }
                tbTotal.Text = venda.ValorTotal.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao mostrar o banco", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método para limpar campos da interface
        /// </summary>
        private void LimparCampos()
        {
            tbCodigo.Text = tbQtd.Text = "";
        }
    }
}
