// Faça um programa que leia o nome de um vendedor, o total de vendas efetuadas por ele no mês (em dinheiro),
// Seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário.
// Sabendo que este vendedor ganha 15% de comissão sobre suas vendas efetuadas,
// Informar o total a receber no final do mês, com duas casas decimais.

Console.WriteLine("Qual o nome do colaborador? ");
string nome = Console.ReadLine();

Console.WriteLine("Qual o valor da hora do colaborador? ");
float valorHora = float.Parse(Console.ReadLine());

Console.WriteLine("Quantas horas o colaborador trabalhou? ");
int horasTrabalhadas = int.Parse(Console.ReadLine());

Console.WriteLine("Qual o valor total (em dinheiro) de vendas do colaborador? ");
float valorVendas = float.Parse(Console.ReadLine());

Salario salario = new();

float salarioHora = salario.CalcularSalarioHora(horasTrabalhadas, valorHora);

float comissao = salario.CalcularComissao(valorVendas);

float salarioTotal = salarioHora + comissao;

Console.WriteLine("\n Olá, " + nome + 
"\n O seu salário foi de: "+ salarioHora + 
"\n Você vendeu R$ " + valorVendas + " em produtos, então a sua comissão de 15% ficou em R$ " + comissao + 
"\n SALÁRIO TOTAL: R$ " + salarioTotal);


