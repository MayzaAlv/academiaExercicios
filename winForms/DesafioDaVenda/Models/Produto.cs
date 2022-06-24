using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDaVenda.Models
{
    public class Produto
    {
        private int id, estoque;
        private string nome, codigoEan;
        private double preco;

        [Key]
        [Required]
        public int Id { get => id; set => id = value; }
        [Required]
        public int Estoque { get => estoque; set => estoque = value; }
        [Required]
        public string Nome { get => nome; set => nome = value; }
        public string CodigoEan { get => codigoEan; set => codigoEan = value; }
        [Required]
        public double Preco { get => preco; set => preco = value; }

        public Produto(string nome, string codigoEan, double preco, int estoque)
        {
            Nome = nome;
            CodigoEan = codigoEan;
            Preco = preco;
            Estoque = estoque;
        }
    }
}
