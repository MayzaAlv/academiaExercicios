/* 1 - Faça um algoritmo para calcular e mostrar a área de um triângulo
 * a partir dos valores da base e da altura lidos pelo teclado:
 * Área do triangulo = (base * altura) / 2; 
 * Teste se a base ou a altura digitada não foi igual a zero.  */

double baseTriangulo, altura, area;

Console.Write("Digite a base: ");
baseTriangulo = double.Parse(Console.ReadLine());

Console.Write("Digite a altura: ");
altura = double.Parse(Console.ReadLine());

if (baseTriangulo == 0 || altura == 0)
{
    Console.WriteLine("Area inválida, resultando 0.");
}
else {
    area = (altura * baseTriangulo) / 2;
    Console.WriteLine("Area = " + area);
}
