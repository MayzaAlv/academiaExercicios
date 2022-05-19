/* 12) Um motorista de taxi deseja calcular o rendimento de seu carro na praça. 
 * Sabendo-se que o preço do combustível é de R$6,90, escreva um algoritmo para ler a 
 * marcação do hodômetro (marcador de quilometragem) no início do dia, a marcação no final 
 * do dia, o número de litros de combustível gasto e o valor total (R$) recebido dos 
 * passageiros. Calcule e escreva a média do consumo em Km/l e o lucro líquido do dia.*/

Console.WriteLine("Exercicio 12: Um motorista de taxi deseja calcular o rendimento de seu carro" +
    " na praça. Sabendo-se que o preço do combustível é de R$6,90, escreva um algoritmo para " +
    "ler a marcação do hodômetro(marcador de quilometragem) no início do dia, a marcação no final " +
    "do dia, o número de litros de combustível gasto e o valor total (R$) recebidodos passageiros." +
    " Calcule e escreva a média do consumo em Km/l e o lucro líquido do dia.\n");

double marcacao_inicio, marcacao_final, litros_gasto, valor_passageiros, valor_total,
        total_quilometragem, media_consumo;

Console.Write("Marcação do hodômetro inicial: ");
marcacao_inicio = double.Parse(Console.ReadLine());
Console.Write("Marcação do hodômetro final: ");
marcacao_final = double.Parse(Console.ReadLine());
Console.Write("Insira o número de litros de combustível: ");
litros_gasto = double.Parse(Console.ReadLine());
Console.Write("Insira o valor total recebido dos passageiros: R$");
valor_passageiros = double.Parse(Console.ReadLine());

total_quilometragem = marcacao_final - marcacao_inicio;
media_consumo = total_quilometragem / litros_gasto;
valor_total = valor_passageiros - (litros_gasto * 6.9);

Console.WriteLine("Média do consumo: R$" + media_consumo + 
    "\nLucro líquido do dia: R$" + valor_total); 
