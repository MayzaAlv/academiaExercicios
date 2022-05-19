/* 7. Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa. 
A cada solicitação, teste se o usuário informou um valor válido. 
Por exemplo: se o nome não for lido corretamente (ou seja, se estiver em branco ou se for um número), 
informe que ele está incorreto e saia do programa em VS. 
Se o nome for lido corretamente, solicite a idade. Se ela for incorreta (menor ou igual a zero), 
informe que está errada e saia. Se estiver correta, solicite o salário. 
Se ele estiver incorreto (menor ou igual a zero), informe que está incorreto e saia. 
Se estiver correto, mostre todos os valores lidos. */

int idade;
string nome;
double salario;


do
{
    Console.Clear();

    Console.Write("\nInsira seu nome: ");
    nome = Console.ReadLine();

    if (nome != " " && nome.All(char.IsDigit) == false)
    {
        break;
    }
    else
    {
        Console.WriteLine("Insira uma nome válido!");
        Thread.Sleep(1000);
    }

} while (true);


do
{
    Console.Clear();

    Console.Write("\nInsira sua idade: ");
    idade = int.Parse(Console.ReadLine());

    if (idade > 0)
    {
        break;
    }
    else
    {
        Console.WriteLine("Insira uma idade válida!");
        Thread.Sleep(1000);
    }

} while (true);


do
{
    Console.Clear();

    Console.Write("\nInsira seu salário: ");
    salario = double.Parse(Console.ReadLine());

    if (salario > 0)
    {
        break;
    }
    else
    {
        Console.WriteLine("Insira uma salário válido!");
        Thread.Sleep(1000);
    }

} while (true);

Console.WriteLine($"\nNome: {nome} \nIdade: {idade} \nSalário: {salario.ToString("F")}");
