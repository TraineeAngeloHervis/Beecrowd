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


