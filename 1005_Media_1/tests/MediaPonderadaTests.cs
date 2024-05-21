using System;
using System.Globalization;
using Xunit;

public class MediaPonderadaTests
{
    [Fact]
    public void TirarMediaPonderada_QuandoValoresValidos_DeveRetornarMedia()
    {
        // Arrange
        MediaPonderada media = new();

        // Act
        double valorA = 5.0, valorB = 7.1, pesoA = 3.5, pesoB = 7.5;
        double resultado = media.TirarMediaPonderada(valorA, valorB, pesoA, pesoB);


        // Assert
        Assert.Equal("6.43182", resultado.ToString("F5", CultureInfo.InvariantCulture));
    }
}