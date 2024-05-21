﻿//Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1
//o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.
//Após, calcule e mostre o valor a ser pago.
using System.Globalization;

int IdPeca1,
    IdPeca2,
    contPeca1,
    contPeca2;
float valorPeca1,
    valorPeca2;

Console.WriteLine("Digite o código da 1ª peça: ");
IdPeca1 = int.Parse(Console.ReadLine());

Console.WriteLine("Quantas unidades serão compradas da 1ª peça? ");
contPeca1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor unitário da 1ª peça: ");
valorPeca1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o código da 2ª peça: ");
IdPeca2 = int.Parse(Console.ReadLine());

Console.WriteLine("Quantas unidades serão compradas da 2ª peça? ");
contPeca2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor unitário da 2ª peça: ");
valorPeca2 = float.Parse(Console.ReadLine());

VendaPeca valores = new();
float resultado = valores.DefinirValor(valorPeca1, valorPeca2, contPeca1, contPeca2);
string resultadoFormatado = resultado.ToString("0.00", CultureInfo.InvariantCulture);
Console.WriteLine("VALOR A PAGAR: R$ " + resultadoFormatado);