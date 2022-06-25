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
    public partial class FrmProduto : Form
    {
        AppDbContext _context = new AppDbContext();
        public FrmProduto()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Criando novo produto no banco e validações se existe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (_context.Produtos.FirstOrDefault(pd => pd.Nome == tbNome.Text) == null 
                && tbNome.Text != "")
            {
                Produto produto = new Produto(tbNome.Text, tbCodigo.Text,
                    double.Parse(tbPreco.Text), int.Parse(tbEstoque.Text));

                _context.Produtos.Add(produto);
                _context.SaveChanges();

                MostrarProduto();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Campo inválido", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Atualizando produto no banco, seu estoque e preço
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Produto produto = _context.Produtos.FirstOrDefault(pd => pd.Nome == tbNome.Text);

                if (produto != null)
                {
                    produto.Estoque = int.Parse(tbEstoque.Text);
                    produto.Preco = double.Parse(tbPreco.Text);

                    _context.Produtos.Update(produto);
                    _context.SaveChanges();

                    MostrarProduto();
                    LimparCampos();
                } 
                else
                {
                    MessageBox.Show("Produto não se encontra no banco de dados", "Conflito",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Erro ao atualizar", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Removendo produto do banco
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                Produto produto = _context.Produtos.FirstOrDefault(pd => pd.Nome == tbNome.Text);

                if (produto != null)
                {
                    _context.Produtos.Remove(produto);
                    _context.SaveChanges();

                    LimparCampos();
                    MessageBox.Show("Removido com sucesso", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Produto não se encontra no banco de dados", "Conflito",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Erro ao remover", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método que mostra informação do produto na tela
        /// </summary>
        private void MostrarProduto()
        {
            Produto produto = _context.Produtos.FirstOrDefault(pd => pd.Nome == tbNome.Text);

            MessageBox.Show($"Nome: {tbNome.Text} \nCódigo: {produto.CodigoEan} \n" +
                $"Estoque: {tbEstoque.Text} \nPreço: {tbPreco.Text}", "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Método para limpar os campos da interface
        /// </summary>
        private void LimparCampos()
        {
            tbNome.Text = tbCodigo.Text = tbEstoque.Text = tbPreco.Text = "";
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmLogin().Show();
            this.Close();
        }

        private void cadastroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmCadastro().Show();
            this.Close();
        }
    }
}
