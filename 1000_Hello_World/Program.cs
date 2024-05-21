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