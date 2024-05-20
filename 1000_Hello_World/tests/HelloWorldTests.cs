using System;
using NUnit.Framework;

public class HelloWorldTests
{
    [Test]
    public void HelloWorld_QuandoMensagemHelloWorld_DeveRetornarFraseCorreta()
    {
        // Arrange
        HelloWorld frase = new HelloWorld();

        // Act
        string resultado = frase.GetHelloWorld();

        // Assert
        Assert.AreEqual("Hello World", resultado);
    }

    [Test]
    public void HelloWorld_QuandoMensagemDiferenteDeHelloWorld_DeveRetornarFraseErrada()
    {
        // Arrange
        HelloWorld frase = new HelloWorld();

        // Act
        string resultado = frase.GetHelloWorld();

        // Assert
        Assert.NotEqual("Hello World", resultado);
    }

}