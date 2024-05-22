//Leia dois valores inteiros, no caso para variáveis A e B. A seguir, calcule a soma entre elas e atribua à variável SOMA.
//A seguir escrever o valor desta variável.

Console.WriteLine("Digite o 1° valor: ");
var A = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o 2° valor: ");
var B = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o 3° valor: ");
var C = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o 4° valor: ");
var D = int.Parse(Console.ReadLine());

CalcularDiferenca calculo = new();
int resultado = calculo.TirarDiferenca(A, B, C, D);

Console.WriteLine("DIFERENCA = " + resultado);