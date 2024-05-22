// A fórmula para calcular a área de uma circunferência é: area = π . raio2. Considerando para este problema que π = 3.14159:
// - Efetue o cálculo da área, elevando o valor de raio ao quadrado e multiplicando por π.

using System;
using System.Globalization;

double raio; 

Console.WriteLine("Digite o valor do Raio: ");
raio = double.Parse(Console.ReadLine(), CultureInfo.CreateSpecificCulture("en-US"));

CalculoArea calculo = new();
double area = calculo.CalcularArea(raio);
Console.WriteLine("A=" + area.ToString("F4", CultureInfo.CreateSpecificCulture("en-US")));