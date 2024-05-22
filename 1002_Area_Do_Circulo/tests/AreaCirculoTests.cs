using Xunit;

public class AreaCirculoTests
{
    [Fact]
    public void Area_QuandoValoresCorretos_DeveRetornarArea()
    {
        // Arrange
        double raio = 2.00;
        CalculoArea CalculoArea = new();

        // Act
        double areaCalculada = CalculoArea.CalcularArea(raio);

        // Assert
        Assert.Equal(12.5664, areaCalculada, 4);
    }
}