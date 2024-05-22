using Xunit;
using System.Globalization;

public class VendaPecaTests
{
    [Fact]
    public void VendaPeca_QuandoValoresCertos_RetornaResultado()
    {
        // Arrange
        VendaPeca valores = new();
        float valorPeca1 = 5.30f;
        float valorPeca2 = 5.10f;
        int contPeca1 = 1;
        int contPeca2 = 2;

        // Act
        float resultado = valores.DefinirValor(valorPeca1, valorPeca2, contPeca1, contPeca2);
        

        // Assert
        Assert.Equal("15.50", resultado.ToString("F2", CultureInfo.InvariantCulture));
    }
}
