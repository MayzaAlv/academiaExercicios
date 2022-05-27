using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1
{
    internal class Personagem
    {
        public string Nome { get; set; }
        public int Poder { get; set; }

        public Personagem() {} 

        public Personagem(string nome, int poder)
        {
            Nome = nome;
            Poder = poder;
        }

        public static string ExibirDados(List<Personagem> personagens) 
        {
            Personagem maisPoderoso = personagens[0];

            foreach (Personagem i in personagens) 
            {
                if (i.Poder > maisPoderoso.Poder) 
                {
                    maisPoderoso = i;
                }
            }

            return $"O personagem mais poderoso é o {maisPoderoso.Nome} com poder de {maisPoderoso.Poder}";
        }
    }
}
