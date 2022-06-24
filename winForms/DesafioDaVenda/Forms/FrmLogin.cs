using DesafioDaVenda.Data;
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
    public partial class FrmLogin : Form
    {
        AppDbContext _context = new AppDbContext();
        public FrmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Conectando o cliente através do CPF a venda,
        /// ademais, validações para saber se existe no banco
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmVenda.clienteId = _context.Clientes.FirstOrDefault(cliente => cliente.Cpf == mtbCpf.Text).Id;
                FrmVenda frm = new FrmVenda();
                frm.Show();
                this.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Usuário não cadastrado ", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            new FrmCadastro().Show();
            this.Close();
        }

        private void menuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FrmMenu().Show();
            this.Close();
        }

        private void cadastroProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmProduto().Show();
            this.Close();
        }
    }
}
