using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafio01
{
    internal class Usuario
    {
        string nome, email, senha, status, tipo;
        int telefone, cpf;

        public Usuario(string nome, string email, string senha, 
            string status, string tipo, int telefone, int cpf)
        {
            this.nome = nome;
            this.email = email;
            this.senha = senha;
            this.status = status;
            this.tipo = tipo;
            this.telefone = telefone;
            this.cpf = cpf;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Status { get => status; set => status = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Telefone { get => telefone; set => telefone = value; }
        public int Cpf { get => cpf; set => cpf = value; }

        public void MostrarDados() {
            MessageBox.Show($"Nome: {this.nome}\n" +
                $"Telefone: {this.telefone}\n" +
                $"CPF: {this.cpf}\n" +
                $"Login: {this.email}\n" +
                $"Senha: {this.senha}\n" +
                $"Status: {this.status}\n" +
                $"Tipo: {this.tipo}\n");
        }
    }
}
