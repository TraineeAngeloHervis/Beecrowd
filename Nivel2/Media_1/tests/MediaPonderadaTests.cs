using System.Globalization;
using Xunit;

public class MediaPonderadaTests {
    [Fact]
    public void TirarMediaPonderada_QuandoValoresValidos_DeveRetornarMedia() {
        //Arrange
        MediaPonderada media = new();

       //Act
        double resultado = media.TirarMediaPonderada(10.0, 2.0, 3.5, 7.5);
        string resultadoFormatado = resultado.ToString("0.#####", CultureInfo.InvariantCulture);

        //Assert
        Assert.Equal("4.54545", resultadoFormatado);
    }

    [Fact]
    
}