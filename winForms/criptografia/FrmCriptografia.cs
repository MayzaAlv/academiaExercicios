using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace criptografia
{
    public partial class FrmCriptografia : Form
    {
        Assimetrica a;
        Simetrica s;
        public FrmCriptografia()
        {
            InitializeComponent();
            a = new Assimetrica();
            s = new Simetrica();
        }

        private void btnCriptoAssimetrico_Click(object sender, EventArgs e)
        {
            string frase = tbFrase.Text;
            string fraseCripto = a.encrypt(frase);
            lblCripto.Text = fraseCripto;
        }

        private void btnDescriptoAssimetrico_Click(object sender, EventArgs e)
        {
            lblDescripto.Text = a.decrypt(lblCripto.Text);
        }

        private void btnCriptoSimetrico_Click(object sender, EventArgs e)
        {
            string frase = tbFrase.Text;
            string chave = tbChave.Text;
            string fraseCripto = s.EncryptData(frase, chave);
            lblCripto.Text = fraseCripto;
        }

        private void btnDescriptoSimetrico_Click(object sender, EventArgs e)
        {
            string frase = lblCripto.Text;
            string chave = tbChave.Text;
            string fraseDescripto = s.DecryptData(frase, chave);
            lblDescripto.Text = fraseDescripto;
        }
    }
}
