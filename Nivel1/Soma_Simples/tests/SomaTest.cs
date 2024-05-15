using System.Reflection;
using Xunit;

public class SomaTest
{
    [Fact]
    public void TesteSoma()
    {
        //Arrange
        Soma soma = new Soma();

        //Act
        int resultado = soma.Somar(30, 10);

        //Assert
        Assert.Equal(40, resultado);
    }
}
