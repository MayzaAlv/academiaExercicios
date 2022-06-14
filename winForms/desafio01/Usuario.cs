using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafio01
{
    public class Usuario
    {
        string nome, email, senha, status, tipo;
        long telefone, cpf;

        public Usuario(string nome, long telefone, long cpf, 
            string email, string senha, string status, string tipo )
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
        public long Telefone { get => telefone; set => telefone = value; }
        public long Cpf { get => cpf; set => cpf = value; }

        public void MostrarDados() {
            MessageBox.Show($"Nome: {this.nome}\n" +
                $"Telefone: {this.telefone}\n" +
                $"CPF: {this.cpf}\n" +
                $"Login: {this.email}\n" +
                $"Senha: {this.senha}\n" +
                $"Status: {this.status}\n" +
                $"Tipo: {this.tipo}\n");
        }

        public override string ToString()
        {
            return this.nome + ";" + this.telefone + ";" + this.cpf 
                + ";" + this.email + ";" + this.senha + ";" + this.status
                + ";" + this.tipo;
        }

        public static Usuario StringToUsuario(string dados)
        {
            string[] vetorDados = dados.Split(';');
            return new Usuario(vetorDados[0], long.Parse(vetorDados[1]), 
                                long.Parse(vetorDados[2]), vetorDados[3], 
                                vetorDados[4], vetorDados[5], vetorDados[6]);
        }
    }
}
