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
        string resultado = string.Empty;
        try
        {
            resultado = valores.DefinirValor(valorPeca1, valorPeca2, contPeca1, contPeca2).ToString("0.00", CultureInfo.InvariantCulture);
        }
        catch (FormatException e)
        {
            throw new System.Exception (e.Message);
        }
        catch (ArgumentException e)
        {
            throw new System.Exception(e.Message);
        }

        // Assert
        Assert.Equal("15.50", resultado);
    }
}
