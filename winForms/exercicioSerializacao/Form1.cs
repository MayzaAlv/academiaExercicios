using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicioSerializacao
{
    public partial class Form1 : Form
    {
        List<Paciente> pacientes = new List<Paciente>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente(tbNome.Text, tbCpf.Text, DateTime.Parse(tbData.Text));
            pacientes.Add(paciente);
            LimparCampos();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            SerializacaoJson.Serializacao(pacientes);
        }

        private void LimparCampos()
        {
            tbNome.Text = tbData.Text = tbCpf.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SerializacaoJson.DesserializarJson();
        }
    }
}
