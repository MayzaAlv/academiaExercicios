using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_desafioWindowsFormOOArquivo
{
    public partial class FrmConsulta : Form
    { 
        /// <summary>
        /// Construtor da classe consulta que inicia os componentes e método que popula a interface
        /// </summary>
        /// <param name="informa">String que informa se é entrada ou saida</param>
        public FrmConsulta(string informa)
        {
            InitializeComponent();

            lblInforma.Text = informa;
            if (informa == "Entrada")
            {
                PopularCheckBoxEntrada();
                PopularTextBoxListaEntrada();
            }   
            else
            {
                PopularCheckBoxSaida();
                PopularTextBoxListaSaida();
            }
        }

        /// <summary>
        /// Método do botão que fecha a aba
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiLista_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Método que remove um veículo da lista e do arquivo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lblInforma.Text == "Entrada")
            {
                FrmCadastro.veiculosEntrada = AtualizarLista(FrmCadastro.veiculosEntrada);
                Persistencia.AtualizarArquivo(FrmCadastro.veiculosEntrada, "veiculosEntrada.dat");
                PopularTextBoxListaEntrada();
            }
            else if (lblInforma.Text == "Saída")
            {
                FrmCadastro.veiculosSaida = AtualizarLista(FrmCadastro.veiculosSaida);
                Persistencia.AtualizarArquivo(FrmCadastro.veiculosSaida, "veiculosSaida.dat");
                PopularTextBoxListaSaida();
            }
        }

        /// <summary>
        /// Método para popular o TextBox com as entradas
        /// </summary>
        private void PopularTextBoxListaEntrada()
        {
            txtLista.Text = "";
            foreach (Veiculo item in FrmCadastro.veiculosEntrada)
            {
                txtLista.AppendText(item.PlacaVeiculo + " - " + item.HoraEntrada.ToString("HH:mm") 
                                    + " - " + item.DataEntrada + Environment.NewLine);
            }
        }

        /// <summary>
        /// Método para popular o TextBox com as saídas
        /// </summary>
        private void PopularTextBoxListaSaida()
        {
            txtLista.Text = "";
            foreach (Veiculo item in FrmCadastro.veiculosSaida)
            {
                txtLista.AppendText(item.PlacaVeiculo + " - " + item.TempoPermanencia
                                    + " - " + item.ValorCobrado + Environment.NewLine);
            }
        }

        /// <summary>
        /// Método para popular o CheckBox com as entrada
        /// </summary>
        private void PopularCheckBoxEntrada()
        {
            foreach (Veiculo item in FrmCadastro.veiculosEntrada)
            {
                cbLista.Items.Add(item.PlacaVeiculo);
            }
        }

        /// <summary>
        /// Método para popular o CheckBox com as saídas
        /// </summary>
        private void PopularCheckBoxSaida()
        {
            foreach (Veiculo item in FrmCadastro.veiculosSaida)
            {
                cbLista.Items.Add(item.PlacaVeiculo);
            }
        }

        /// <summary>
        /// Método para atualizar a lista depois de remover o veículo
        /// </summary>
        private List<Veiculo> AtualizarLista(List<Veiculo> veiculos)
        {
            foreach (Veiculo item in veiculos)
            {
                if (cbLista.Text == item.PlacaVeiculo)
                {
                    veiculos.Remove(item);
                    break;
                }
            }
            return veiculos;
        }
    }
}
