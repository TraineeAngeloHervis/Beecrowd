//Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1
//o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.
//Após, calcule e mostre o valor a ser pago.
using System.Globalization;

Console.WriteLine("Digite o código da 1ª peça, quantas unidades e o valor unitário (Ex: 10 2 5.50): ");
string[] peca1 = Console.ReadLine().Split(' ');

Console.WriteLine("Digite o código da 2ª peça, quantas unidades e o valor unitário (Ex: 10 2 5.50): ");
string[] peca2 = Console.ReadLine().Split(' ');

int codPeca1 = int.Parse(peca1[0]);
int contPeca1 = int.Parse(peca1[1]);
float valorPeca1 = float.Parse(peca1[2], CultureInfo.InvariantCulture);
int codPeca2 = int.Parse(peca2[0]);
int contPeca2 = int.Parse(peca2[1]);
float valorPeca2 = float.Parse(peca2[2], CultureInfo.InvariantCulture);


VendaPeca valores = new();
float resultado = valores.DefinirValor(valorPeca1, valorPeca2, contPeca1, contPeca2);
string resultadoFormatado = resultado.ToString("0.00", CultureInfo.InvariantCulture);
Console.WriteLine("VALOR A PAGAR: R$ " + resultadoFormatado);
