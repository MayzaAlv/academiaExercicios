using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioSerializacao
{
    public class Paciente
    {
        string nome, cpf;
        DateTime dataNascimento;

        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }

        public Paciente(string nome, string cpf, DateTime dataNascimento)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.dataNascimento = dataNascimento;
        }
    }
}
