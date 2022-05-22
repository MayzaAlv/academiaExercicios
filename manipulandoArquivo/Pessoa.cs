using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    internal class Pessoa
    {   
        public Guid Id { get; private set; }
        public string Nome { get; set; }
        public string Email { get; }

        public Pessoa(string nome, string email)
        {
            this.Id = Guid.NewGuid();
            Nome = nome;

            if (validandoEmail(email))
            {
                Email = email;
            }
        }


        private bool validandoEmail(string email)
        {
            if (!email.Contains("@") || email.Contains(" "))
            {
                Console.WriteLine("Email Inválido!");
                return false;
            }

            return true;
        }
    }
}
