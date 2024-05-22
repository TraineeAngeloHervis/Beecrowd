// O seu primeiro programa em qualquer linguagem de programação normalmente é o "Hello World!".
// Neste primeiro problema tudo o que você precisa fazer é imprimir esta mensagem na tela.

string frase;

Console.WriteLine("Digite sua Frase: (Hello World!)");
frase = Console.ReadLine();


HelloWorld helloWorld = new HelloWorld();

var fraseEstaCorreta = helloWorld.GetHelloWorld(frase);

if (fraseEstaCorreta)
{
    Console.WriteLine("Você digitou a frase correta!");
}
else
{
    Console.WriteLine("Você digitou a frase errada!");
}