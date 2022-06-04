using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafio01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(tbNome.Text == "" || tbLogin.Text == "" || tbSenha.Text == "" 
                || cbStatus.Text == "" || cbTipo.Text == "" || tbTelefone.Text == "" 
                || tbCpf.Text == "")
            {
                MessageBox.Show("Dados Incompletos!");
            } 
            else
            {
                Usuario user = new Usuario(tbNome.Text, tbLogin.Text,
                tbSenha.Text, cbStatus.Text, cbTipo.Text,
                int.Parse(tbTelefone.Text), int.Parse(tbCpf.Text));

                user.MostrarDados();

                tbNome.Clear();
                tbLogin.Clear();
                tbSenha.Clear();
                cbStatus.ResetText();
                cbTipo.ResetText();
                tbTelefone.Clear();
                tbCpf.Clear();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
