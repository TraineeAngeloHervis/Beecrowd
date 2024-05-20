using Xunit;

public class SomaTests
{
    [Fact]
    public void Soma_QuandoValoresValidos_DeveRetornarSoma()
    {
        //Arrange
        Soma soma = new();

        //Act
        int resultado = soma.Somar(30, 10);

        //Assert
        Assert.Equal(40, resultado);
    }
}
