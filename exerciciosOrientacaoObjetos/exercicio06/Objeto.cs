using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio06
{
    internal class Objeto
    {
        private int x;
        private int y;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public Objeto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static void ExibirDados(List<Objeto> objetos)
        {
            foreach (Objeto objeto in objetos)
            {
                Console.WriteLine($"\nPosição X: {objeto.X} \nDescrição: {objeto.Y}");
            }

            if (objetos.Count == 0)
            {
                Console.WriteLine("Lista vazia!");
            }
        }
    }
}
