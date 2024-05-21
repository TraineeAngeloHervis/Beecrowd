using Xunit;

public class SomaTests
{
    [Fact]
    public void Soma_QuandoValoresValidos_DeveRetornarSoma()
    {
        //Arrange
        Somar somar = new();

        //Act
        int resultado = somar.Somando(30, 10);

        //Assert
        Assert.Equal(40, resultado);
    }
}
