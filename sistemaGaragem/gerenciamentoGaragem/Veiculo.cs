using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerenciamentoGaragem
{
    internal class Veiculo
    {
        string placa;
        DateTime dataHoraEntrada;

        public string Placa { get => placa; set => placa = value; }
        public DateTime DataHoraEntrada { get => dataHoraEntrada; }

        public Veiculo(string placa)
        {
            this.placa = placa;
            this.dataHoraEntrada = DateTime.Now;
        }

        public Veiculo(string placa, string dataHoraEntrada)
        {
            this.placa = placa;
            this.dataHoraEntrada = DateTime.Parse(dataHoraEntrada);
        }
    }
}
