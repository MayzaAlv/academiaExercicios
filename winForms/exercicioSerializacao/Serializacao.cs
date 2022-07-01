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
    public partial class Serializacao : Form
    {
        List<Paciente> pacientes = new List<Paciente>();
        public Serializacao()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente(tbNome.Text, tbCpf.Text, DateTime.Parse(tbData.Text));
            pacientes.Add(paciente);
            LimparCampos();
        }

        private void btnSerializar_Click(object sender, EventArgs e)
        {
            SerializacaoJson.Serializacao(pacientes);
            tbLista.Text = Arquivo.lerArquivo(SerializacaoJson.path);
        }

        private void LimparCampos()
        {
            tbNome.Text = tbData.Text = tbCpf.Text = "";
        }

        private void btnDesserializar_Click(object sender, EventArgs e)
        {
            SerializacaoJson.DesserializarJson();
        }
    }
}
