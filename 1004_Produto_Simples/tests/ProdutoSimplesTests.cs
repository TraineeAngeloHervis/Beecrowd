using Xunit;

public class ProdutoSimplesTests
{
    [Fact]
    public void Produto_QuandoValoresValidos_DeveRetornarProduto()
    {
        //Arrange
        Produto calculo = new();

        //Act
        int resultado = calculo.Multiplicar(3, 2);

        //Assert
        Assert.Equal(6, resultado);
    }
}
