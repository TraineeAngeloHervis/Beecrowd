// Leia 2 valores inteiros e armazene-os nas variáveis A e B.
// Efetue a soma de A e B atribuindo o seu resultado na variável X.

Console.WriteLine("Digite o primeiro valor: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo valor: ");
int B = int.Parse(Console.ReadLine());
Somar soma = new();
int resultado = soma.Somando(A, B);

Console.WriteLine("SOMA = " + resultado);
