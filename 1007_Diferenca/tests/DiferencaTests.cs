using Xunit;

public class ProdutoSimplesTests
{
    [Fact]
    public void Diferenca_QuandoValoresValidos_DeveRetornarDiferenca()
    {
        //Arrange
        CalcularDiferenca calculo = new();

        //Act
        int resultado = calculo.TirarDiferenca(5, 6, 7, 8);

        //Assert
        Assert.Equal(-26, resultado);
    }
}
