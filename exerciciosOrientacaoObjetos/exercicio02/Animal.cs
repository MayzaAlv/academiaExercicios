using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2
{
    internal class Animal
    {
        private string nome, tipo;

        public string Nome { get => nome; set => nome = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        public Animal(string nome, string tipo)
        {
            this.nome = nome;
            this.tipo = tipo;
        }

        public static void Iniciar() 
        {
            List<Animal> animais = new List<Animal>();
            string nome, tipo;


            for (int i = 0; i < 5; i++)
            {
                Console.Write("\nInsira o nome do animal: ");
                nome = Console.ReadLine();

                do
                {
                    Console.Write("Insira o tipo do animal: ");
                    tipo = Console.ReadLine().ToLower();

                    if (tipo != "cachorro" && tipo != "gato" && tipo != "peixe")
                    {
                        Console.WriteLine("\nInsira um tipo válido (cachorro, gato ou peixe)!");
                    }
                    else
                    {
                        break;
                    }

                } while (true);

                animais.Add(new Animal(nome, tipo));
            }

            Console.WriteLine(ExibirQuantidade(animais));
        }


        private static string ExibirQuantidade(List<Animal> animais)
        {
            int cachorro = 0, gato = 0, peixe = 0;

            foreach (Animal i in animais) 
            {
                if (i.Tipo == "cachorro") 
                {
                    cachorro++;
                }
                if (i.Tipo == "gato")
                {
                    gato++;
                }
                if (i.Tipo == "peixe")
                {
                    peixe++;
                }
            }

            return $"\nCachorro: {cachorro} \nGato: {gato} \nPeixe: {peixe}";
        }
        
    }
}
