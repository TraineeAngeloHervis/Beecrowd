//Leia 2 valores de ponto flutuante de dupla precisão A e B, que correspondem a 2 notas de um aluno.
//A seguir, calcule a média do aluno, sabendo que a nota A tem peso 3.5 e a nota B tem peso 7.5 (A soma dos pesos portanto é 11).
//Assuma que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.

using System;
using System.Globalization;

double valorA,
    valorB,
    pesoA,
    pesoB;

Console.WriteLine("Digite o peso da 1° Nota: ");
pesoA = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a 1° Nota: ");
valorA = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o peso da 2° Nota: ");
pesoB = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a 2° Nota: ");
valorB = double.Parse(Console.ReadLine());

MediaPonderada media = new();

double resultado = media.TirarMediaPonderada(valorA, valorB, pesoA, pesoB);
Console.WriteLine("MEDIA = " + resultado.ToString("F1", CultureInfo.InvariantCulture));
