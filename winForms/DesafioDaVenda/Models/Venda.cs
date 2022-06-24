using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDaVenda.Models
{
    public class Venda
    {
        private int id, clienteId;
        private double valorTotal;
        private ICollection<ItemVenda> itens;

        [Key]
        [Required]
        public int Id { get => id; set => id = value; }
        [Required]
        public int ClienteId { get => clienteId; set => clienteId = value; }
        public double ValorTotal { get => valorTotal; set => valorTotal = value; }

        public Venda(int clienteId, double valorTotal)
        {
            ClienteId = clienteId;
            ValorTotal = valorTotal;
        }
    }
}
