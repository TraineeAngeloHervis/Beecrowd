//Leia dois valores inteiros, no caso para variáveis A e B. A seguir, calcule a soma entre elas e atribua à variável SOMA.
//A seguir escrever o valor desta variável.

int ValorA, ValorB, Soma;

ValorA = int.Parse(Console.ReadLine());
ValorB = int.Parse(Console.ReadLine());
Soma = ValorA + ValorB;

Console.WriteLine("SOMA = " + Soma);
Console.Read();