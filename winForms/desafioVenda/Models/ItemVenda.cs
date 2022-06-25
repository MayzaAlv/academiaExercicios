using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDaVenda.Models
{
    public class ItemVenda
    {
        /// <summary>
        /// Atributos da tabela ItemVenda
        /// </summary>
        private int id, vendaId, produtoId, quantidade;
        private double valorTotal;
        private Produto produto;
        private Venda venda;

        [Key]
        [Required]
        public int Id { get => id; set => id = value; }
        [Required]
        [ForeignKey("Venda")]
        public int VendaId { get => vendaId; set => vendaId = value; }
        [Required]
        [ForeignKey("Produto")]
        public int ProdutoId { get => produtoId; set => produtoId = value; }
        [Required]
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public double ValorTotal { get => valorTotal; set => valorTotal = value; }
        
        // Campo requirido para ser feita a ligação e criação da foreign key
        public Produto Produto { get => produto; set => produto = value; }
        public Venda Venda { get => venda; set => venda = value; }

        /// <summary>
        /// Construtor da classe ItemVenda
        /// </summary>
        /// <param name="vendaId"></param>
        /// <param name="produtoId"></param>
        /// <param name="quantidade"></param>
        /// <param name="valorTotal"></param>
        public ItemVenda(int vendaId, int produtoId, int quantidade, double valorTotal)
        {
            VendaId = vendaId;
            ProdutoId = produtoId;
            Quantidade = quantidade;
            ValorTotal = valorTotal;
        }
    }
}
