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
    public partial class FrmCadastro : Form
    {
        AppDbContext _context = new AppDbContext();
        public FrmCadastro()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adicionando um cliente no banco, filtrando pelas validações
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbNome.Text != "" && mtbCpf.Text != "")
                {
                    if (_context.Clientes.FirstOrDefault(cliente => cliente.Cpf == mtbCpf.Text) == null) 
                    {
                        Cliente cliente = new Cliente(tbNome.Text, tbEmail.Text, mtbCpf.Text, mtbTelefone.Text);

                        _context.Clientes.Add(cliente);
                        _context.SaveChanges();

                        FrmVenda.clienteId = _context.Clientes.FirstOrDefault(cpf => mtbCpf.Text == cpf.Cpf).Id;
                        FrmVenda frmVenda = new FrmVenda();
                        frmVenda.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("CPF existente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Campos inválidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Erro ao adicionar", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmLogin().Show();
            this.Close();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmProduto().Show();
            this.Close();
        }

        private void menuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FrmMenu().Show();
            this.Close();
        }
    }
}
