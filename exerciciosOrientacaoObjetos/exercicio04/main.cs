using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio04
{
    internal class main
    {
        public static void Main() 
        {
            List<Asteroide> asteroides = new List<Asteroide>();

            int posicaoX, posicaoY, tamanho, i = 1;
            double velocidade, energia;
            string opcao;

            do
            {
                Console.WriteLine("\n1 - Criar um asteroide");
                Console.WriteLine("2 - Exibir lista de asteroide");
                Console.WriteLine("3 - Sair");

                Console.Write("\nInsira a opção: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Clear();

                        Console.Write("Insira a posição x: ");
                        posicaoX = int.Parse(Console.ReadLine());

                        Console.Write("Insira a posição y: ");
                        posicaoY = int.Parse(Console.ReadLine());

                        Console.Write("Insira o tamanho (1 a 10): ");
                        tamanho = int.Parse(Console.ReadLine());

                        Console.Write("Insira a velocidade (1 a 5): ");
                        velocidade = double.Parse(Console.ReadLine());

                        Console.Write("Insira a energia (1 a 5): ");
                        energia = double.Parse(Console.ReadLine());

                        asteroides.Add(new Asteroide(posicaoX, posicaoY, tamanho, velocidade, energia));
                        break;

                    case "2":
                        Console.Clear();

                        foreach (Asteroide asteroide in asteroides)
                        {
                            Console.WriteLine($"\nAsteroide {i}: ");
                            Console.WriteLine("Posição x = " + asteroide.X);
                            Console.WriteLine("Posição y = " + asteroide.Y);
                            Console.WriteLine("Tamanho = " + asteroide.Tamanho);
                            Console.WriteLine("Velocidade = " + asteroide.Velocidade);
                            Console.WriteLine("Energia = " + asteroide.Energia);

                            i++;
                        }
                        break;

                    case "3":
                        Console.WriteLine("Obrigado por usar o programa!");
                        break;

                    default:
                        Console.WriteLine("Insira uma posição válida!");
                        break;
                }
            }
            while (opcao != "3");
        }
    }
}
