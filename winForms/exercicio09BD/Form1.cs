using exercicio09BD.Data;
using exercicio09BD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio09BD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        AppDbContext _context = new AppDbContext();

        private void btnConectar_Click(object sender, EventArgs e)
        {
            carregarDados();
            MessageBox.Show("Sucesso ao conectar o banco", "Conexão",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                string email = gerarEmail(txtNome.Text);

                Usuario usuario = new Usuario { Nome = txtNome.Text, Email = email };

                _context.Usuarios.Add(usuario);
                _context.SaveChanges();

                carregarDados();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha em adicionar o usuário: " + erro.ToString(), "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = _context.Usuarios.FirstOrDefault(x => x.Nome == txtNome.Text);
                _context.Usuarios.Remove(usuario);
                _context.SaveChanges();
            }
            catch(Exception erro)
            {
                MessageBox.Show("Usuário não encontrado: " + erro.ToString(), "Erro", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            carregarDados();
        }

        private void carregarDados()
        {
            lvDados.Items.Clear();

            try
            {
                List<Usuario> usuarios = _context.Usuarios.ToList();
                int contador = 0;

                foreach (Usuario usuario in usuarios)
                {
                    lvDados.Items.Add(usuario.Id.ToString());
                    lvDados.Items[contador].SubItems.Add(usuario.Nome);
                    lvDados.Items[contador].SubItems.Add(usuario.Email);

                    contador++;
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao mostrar o banco: " + erro.ToString(), "Erro", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string gerarEmail(string nome)
        {
            string[] vetorDados = nome.Split(' ');
            return vetorDados[vetorDados.Length - 1] + vetorDados[0] + "@ufn.edu.br";
        }
    }
}
