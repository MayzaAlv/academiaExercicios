/* 12 - Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", 
 * respectivamente código e número de horas trabalhadas de um operário. Na sequência,
 * calcule o salário sabendo-se que ele ganha R$ 10,00 por hora. Quando o número de 
 * horas exceder a 50 calcule o excesso de pagamento armazenando-o na variável 
 * "extra", caso contrário zerar tal variável. A hora excedente de trabalho vale R$ 20,00. 
 * No final do processamento, exibir o salário total e o salário excedente do operário. */

int codigo, numeroHoras, extra;
double salario = 0, salarioExcedente = 0;

Console.Write("Insira seu código: ");
codigo = int.Parse(Console.ReadLine());

Console.Write("Insira suas horas trabalhadas: ");
numeroHoras = int.Parse(Console.ReadLine());


if (numeroHoras > 50)
{
    extra = numeroHoras - 50;   
    salarioExcedente = extra * 20;
    salario = (numeroHoras - extra) * 10;
}
else {
    salario = numeroHoras * 10;
}

Console.WriteLine($"\nSalário total: {(salario + salarioExcedente).ToString("F")} " +
            $"\nSalário Excedente: {salarioExcedente.ToString("F")}");
