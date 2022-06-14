using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafio01
{
    public partial class CriandoPerfil : Form
    {
        public static Usuario usuario;

        public CriandoPerfil()
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
                Usuario user = new Usuario(tbNome.Text, long.Parse(tbTelefone.Text),
                    long.Parse(tbCpf.Text), tbLogin.Text, tbSenha.Text, 
                    cbStatus.Text, cbTipo.Text);

                try
                {
                    openFileDialog1.ShowDialog();
                    string filename = openFileDialog1.FileName;

                    StreamWriter escritor = new StreamWriter(filename, true);
                    
                    escritor.WriteLine(user.ToString());
                    escritor.Flush();
                    escritor.Close();
                }
                catch (Exception)
                {
                    Console.WriteLine("Arquivo de usuários com problemas");
                }

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

        private void AbrirArquivo_Click(object sender, EventArgs e)
        {
            string[] vetorDados;

            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            string readFile = File.ReadAllText(filename);

            vetorDados = readFile.Split('\n');

            List<Usuario> usuarios = new List<Usuario>();

            foreach (string item in vetorDados)
            {
                if (item.Count() > 5)
                {
                    usuarios.Add(Usuario.StringToUsuario(item));
                }
            }

            var selecionarUsuario = new SelecionarUsuario(usuarios);
            selecionarUsuario.ShowDialog();

            tbNome.Text = CriandoPerfil.usuario.Nome;
            tbTelefone.Text = Convert.ToString(CriandoPerfil.usuario.Telefone);
            tbCpf.Text = Convert.ToString(CriandoPerfil.usuario.Cpf);
            tbLogin.Text = CriandoPerfil.usuario.Email;
            tbSenha.Text = CriandoPerfil.usuario.Senha;
            cbStatus.Text = CriandoPerfil.usuario.Status;
            cbTipo.Text = CriandoPerfil.usuario.Tipo;
        }
    }
}
