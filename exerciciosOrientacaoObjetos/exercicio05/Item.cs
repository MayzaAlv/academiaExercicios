using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio05
{
    internal class Item
    {
        private string descricao, nome;
        private DateTime data;
        private double altura;

        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public DateTime Data { get => data; set => data = value; }
        public double Altura { get => altura; set => altura = value; }
        

        public Item(string nome, string descricao, double altura)
        {
            this.nome = nome;
            data = DateTime.Now;
            this.descricao = descricao;
            this.altura = altura;
        }


        public static void ExibirDados(List<Item> itens)
        {
            foreach (Item item in itens)
            {
                Console.WriteLine($"\nNome: {item.Nome} \nDescrição: {item.Descricao}");
                Console.WriteLine($"Data de criação: {item.Data} \nAltura: {item.Altura}");
            }
        }


        public static void ExibirDadosItem(List<Item> itens)
        {
            bool flag = true;
            string dados;

            Console.Clear();

            do
            {
                Console.Write("Insira o item que deseja ver os dados: ");
                dados = Console.ReadLine();

                if (itens.Count() == 0)
                {
                    Console.WriteLine("Lista vazia!");
                    break;
                }

                foreach (Item item in itens)
                {
                    if (item.Nome == dados)
                    {
                        Console.WriteLine($"\nNome: {item.Nome} \nDescrição: {item.Descricao}");
                        Console.WriteLine($"Data de criação: {item.Data} \nAltura: {item.Altura}");
                        flag = false;
                    }
                    else
                    {
                        Console.WriteLine("Insira um nome valido!");
                        break;
                    }
                }
            } while (flag);

        }


        public static void ExibirData(List<Item> itens) 
        {
            bool flag = true;
            string dados;

            Console.Clear();

            do
            {
                Console.Write("Insira o item que deseja ver a data: ");
                dados = Console.ReadLine();

                if (itens.Count() == 0)
                {
                    Console.WriteLine("Lista vazia!");
                    break;
                }

                foreach (Item item in itens)
                {
                    if (item.Nome == dados)
                    {
                        Console.WriteLine($"Data de criação: {item.Data}");
                        flag = false;
                    }
                    else
                    {
                        Console.WriteLine("Insira um nome valido!");
                        break;
                    }
                }
            } while (flag);
        }
    }
}
