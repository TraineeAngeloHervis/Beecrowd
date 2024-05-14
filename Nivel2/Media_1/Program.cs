//Leia 2 valores de ponto flutuante de dupla precisão A e B, que correspondem a 2 notas de um aluno.
//A seguir, calcule a média do aluno, sabendo que a nota A tem peso 3.5 e a nota B tem peso 7.5 (A soma dos pesos portanto é 11).
//Assuma que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.
double A, B, media, pesoA = 3.5, pesoB = 7.5;

A = double.Parse(Console.ReadLine());
B = double.Parse(Console.ReadLine());

media = (A*pesoA + B*pesoB) / (pesoA + pesoB);
Console.WriteLine("MEDIA = " + media);