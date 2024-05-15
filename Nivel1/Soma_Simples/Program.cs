//Leia dois valores inteiros, no caso para variáveis A e B. A seguir, calcule a soma entre elas e atribua à variável SOMA.
//A seguir escrever o valor desta variável.

int valorA,
    valorB;
Console.WriteLine("Digite o primeiro valor: ");
valorA = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo valor: ");
valorB = int.Parse(Console.ReadLine());
Soma soma = new();
int resultado = soma.Somar(valorA, valorB);

Console.WriteLine("SOMA = " + resultado);