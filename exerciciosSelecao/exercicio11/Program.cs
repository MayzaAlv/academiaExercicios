/* 11 - Faça um programa no VS que receba uma hora, dividida em 2 variáveis 
 * (uma para hora e outra para minutos).O programa deve exibir se a hora 
 * digitada está ou não válida. Lembre que usaremos o padrão de hora com 24h, de 0 a 23. */

int hora, minutos;

Console.Write("Insira a hora: ");
hora = int.Parse(Console.ReadLine());

Console.Write("Insira os minutos: ");
minutos = int.Parse(Console.ReadLine());

if (hora > 23 || 0 > hora)
{
    Console.WriteLine("Hora inválida!");
}
else {
    Console.WriteLine("Hora válida!");
}