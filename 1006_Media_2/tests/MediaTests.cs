using System;
using System.Globalization;
using Xunit;

public class MediaTests
{
    [Fact]
    public void TirarMediaPonderada_QuandoValoresValidos_DeveRetornarMedia()
    {
        // Arrange
        MediaPonderada media = new();

        // Act
        double valorA = 5.0, valorB = 6.0, valorC = 7.0, pesoA = 2.0, pesoB = 3.0, pesoC = 5.0;
        double resultado = media.TirarMediaPonderada(valorA, valorB, valorC, pesoA, pesoB, pesoC);


        // Assert
        Assert.Equal("6.3", resultado.ToString("F1", CultureInfo.InvariantCulture));
    }
}