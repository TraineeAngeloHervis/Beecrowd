//Leia dois valores inteiros, no caso para variáveis A e B. A seguir, calcule a soma entre elas e atribua à variável SOMA.
//A seguir escrever o valor desta variável.

Console.WriteLine("Digite o primeiro valor: ");
var A = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo valor: ");
var B = int.Parse(Console.ReadLine());
Produto calculo = new();
int resultado = calculo.Multiplicar(A, B);

Console.WriteLine("PROD = " + resultado);