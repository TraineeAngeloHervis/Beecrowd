//Leia 2 valores de ponto flutuante de dupla precisão A e B, que correspondem a 2 notas de um aluno.
//A seguir, calcule a média do aluno, sabendo que a nota A tem peso 3.5 e a nota B tem peso 7.5 (A soma dos pesos portanto é 11).
//Assuma que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.
using System.Globalization;

double valorA, valorB, pesoA = 3.5, pesoB = 7.5;

Console.WriteLine("Digite o primeiro valor: ");
valorA = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo valor: ");
valorB = double.Parse(Console.ReadLine());
MediaPonderada media = new();

double resultado = media.TirarMediaPonderada(valorA, valorB, pesoA, pesoB);
string resultadoFormatado = resultado.ToString("0.#####", CultureInfo.InvariantCulture);
Console.WriteLine("MEDIA = " + resultadoFormatado);