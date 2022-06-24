﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDaVenda.Models
{
    public class Venda
    {
        /// <summary>
        /// Atributos da tabela Venda
        /// </summary>
        private int id, clienteId;
        private double valorTotal;

        [Key]
        [Required]
        public int Id { get => id; set => id = value; }
        [Required]
        [ForeignKey("Cliente")]
        public int ClienteId { get => clienteId; set => clienteId = value; }
        public double ValorTotal { get => valorTotal; set => valorTotal = value; }

        /// <summary>
        /// Construtor da classe Venda
        /// </summary>
        /// <param name="clienteId"></param>
        /// <param name="valorTotal"></param>
        public Venda(int clienteId, double valorTotal)
        {
            ClienteId = clienteId;
            ValorTotal = valorTotal;
        }
    }
}
