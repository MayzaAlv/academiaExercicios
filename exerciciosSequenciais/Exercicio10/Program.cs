/* 10) Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo 
para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que 
realizou o saque. Um possível critério seria o da “distribuição ótima” no sentido de que as 
notas de menor valor fossem distribuídas em número mínimo possível. 
Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00, 
três notas de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00. 
Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas 
de acordo com o critério da “distribuição ótima”. */

Console.WriteLine("Exercício 10: Um programa para gerenciar os saques de um caixa eletrônico" +
    " deve possuir algum mecanismo para decidir o número de notas de cada valor que deve ser" +
    " disponibilizado para o cliente que realizou o saque.Um possível critério seria o da " +
    "“distribuição ótima” no sentido de que asnotas de menor valor fossem distribuídas em " +
    "número mínimo possível.\n");

float preco;
int[] notas = new int [8];

Console.Write("Insira o valor que deseja sacar: R$");
preco = float.Parse(Console.ReadLine());

notas[0] = (int)Math.Floor(preco / 200);
preco %= 200;
notas[1] = (int)Math.Floor(preco / 100);
preco %= 100;
notas[2] = (int)Math.Floor(preco / 50);
preco %= 50;
notas[3] = (int)Math.Floor(preco / 20);
preco %= 20;
notas[4] = (int)Math.Floor(preco / 10);
preco %= 10;
notas[5] = (int)Math.Floor(preco / 5);
preco %= 5;
notas[6] = (int)Math.Floor(preco / 2);
preco %= 2;
notas[7] = (int)Math.Floor(preco / 1);
preco %= 1;

Console.WriteLine(notas[0] + " notas de R$200\n" + notas[1] + " notas de R$100\n" +
                notas[2] + " notas de R$50\n" + notas[3] + " notas de R$20\n" + notas[4]
                + " notas de R$10\n" + notas[5] + " notas de R$5\n" + notas[6] + " notas de R$2\n" +
                notas[7] + " notas de R$1");

