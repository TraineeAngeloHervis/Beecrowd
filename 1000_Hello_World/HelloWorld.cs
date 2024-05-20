using System;

public class HelloWorld
{
    public string GetHelloWorld()
    {
        string frase = Console.ReadLine();

        if (frase == "Hello World!")
        {
            Console.WriteLine("Você digitou a frase correta!");
        }
        else
        {
            Console.WriteLine("Você digitou a frase errada!");
        }

        return frase;
    }
}
