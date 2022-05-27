using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio04
{
    internal class Asteroide
    {
        private int x, y, tamanho;
        private double velocidade, energia;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Tamanho { get => tamanho; set => tamanho = value; }
        public double Velocidade { get => velocidade; set => velocidade = value; }
        public double Energia { get => energia; set => energia = value; }

        public Asteroide() {}

        public Asteroide(int x, int y, int tamanho, double velocidade, double energia) : this(x, y)
        {
            this.tamanho = tamanho;
            this.velocidade = velocidade;
            this.energia = energia;
        }

        public Asteroide(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
