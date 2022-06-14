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
    public partial class SelecionarUsuario : Form
    {
        List<Usuario> usuarios = new List<Usuario>();   

        public SelecionarUsuario(List<Usuario> usuarios)
        { 
            this.usuarios = usuarios;
            InitializeComponent();

            foreach (Usuario item in usuarios)
            {   
                cbSelecao.Items.Add(item.Email);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            foreach (Usuario item in usuarios)
            {
                if (item.Email == cbSelecao.Text)
                {
                    CriandoPerfil.usuario = item;
                    this.Close();
                    return; 
                }
            }
        }
    }
}
