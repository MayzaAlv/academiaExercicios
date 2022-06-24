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


        public Cliente(string nome, string email, string cpf, string telefone)
        {
            Nome = nome;
            Email = email;
            Cpf = cpf;
            Telefone = telefone;
        }
    }
}
