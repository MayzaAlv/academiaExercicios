using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDaVenda.Models
{
    public class Cliente
    {   
        /// <summary>
        /// Atributos da tabela Cliente
        /// </summary>
        private int id;
        private string nome, email, cpf, telefone;


        [Key]
        [Required]
        public int Id { get => id; set => id = value; }
        [Required]
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        [Required]
        public string Cpf { get => cpf; set => cpf = value; }
        public string Telefone { get => telefone; set => telefone = value; }

        /// <summary>
        /// Costrutor da classe
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="email"></param>
        /// <param name="cpf"></param>
        /// <param name="telefone"></param>
        public Cliente(string nome, string email, string cpf, string telefone)
        {
            Nome = nome;
            Email = email;
            Cpf = cpf;
            Telefone = telefone;
        }
    }
}
