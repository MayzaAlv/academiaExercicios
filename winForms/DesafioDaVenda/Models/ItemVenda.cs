using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDaVenda.Models
{
    public class ItemVenda
    {
        private int id, vendaId, produtoId, quantidade;
        private double valorTotal;
        private Venda venda;

        [Key]
        [Required]
        public int Id { get => id; set => id = value; }
        [Required]
        public int VendaId { get => vendaId; set => vendaId = value; }
        [Required]
        public int ProdutoId { get => produtoId; set => produtoId = value; }
        [Required]
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public double ValorTotal { get => valorTotal; set => valorTotal = value; }

        public ItemVenda(int vendaId, int produtoId, int quantidade, double valorTotal)
        {
            VendaId = vendaId;
            ProdutoId = produtoId;
            Quantidade = quantidade;
            ValorTotal = valorTotal;
        }
    }
}
