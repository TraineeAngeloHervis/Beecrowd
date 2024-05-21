using Xunit;

public class HelloWorldTests
{
    [Fact]
    public void HelloWorld_QuandoFraseCorreta_DeveRetornarTrue()
    {
        // Arrange
        HelloWorld helloWorld = new HelloWorld();
        string fraseEsperada = "Hello World!";

        // Act
        bool fraseEstaCorreta = helloWorld.GetHelloWorld(fraseEsperada);

        // Assert
        Assert.True(fraseEstaCorreta);
    }

}