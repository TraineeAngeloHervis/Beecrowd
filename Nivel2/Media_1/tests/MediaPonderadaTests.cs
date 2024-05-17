// using System;
// using System.Globalization;
// using Xunit;

// public class MediaPonderadaTests
// {
//     [Fact]
//     public void TirarMediaPonderada_QuandoValoresValidos_DeveRetornarMedia()
//     {
//         // Arrange
//         MediaPonderada media = new();

//         // Act
//         double resultado = media.TirarMediaPonderada(10.0, 2.0, 3.5, 7.5);
//         string resultadoFormatado = resultado.ToString("0.#####", CultureInfo.InvariantCulture);

//         // Assert
//         Assert.Equal("4.54545", resultadoFormatado);
//     }

//     [Fact]
//     public void TirarMediaPonderada_QuandoPesoANegativo_DeveLancarArgumentException()
//     {
//         // Arrange
//         MediaPonderada media = new();

//         // Act
//         Action act = () => media.TirarMediaPonderada(10.0, 2.0, -3.5, 7.5);

//         // Assert
//         ArgumentException exception = Assert.Throws<ArgumentException>(act);
//         Assert.Equal("Os pesos devem ser maiores ou iguais a zero.", exception.Message);
//     }

//     [Fact]
//     public void TirarMediaPonderada_QuandoPesoBNegativo_DeveLancarArgumentException()
//     {
//         // Arrange
//         MediaPonderada media = new();

//         // Act
//         Action act = () => media.TirarMediaPonderada(10.0, 2.0, 3.5, -7.5);

//         // Assert
//         ArgumentException exception = Assert.Throws<ArgumentException>(act);
//         Assert.Equal("Os pesos devem ser maiores ou iguais a zero.", exception.Message);
//     }

//     [Fact]
//     public void TirarMediaPonderada_QuandoPesosNegativos_DeveLancarArgumentException()
//     {
//         // Arrange
//         MediaPonderada media = new();

//         // Act
//         Action act = () => media.TirarMediaPonderada(10.0, 2.0, -3.5, -7.5);

//         // Assert
//         ArgumentException exception = Assert.Throws<ArgumentException>(act);
//         Assert.Equal("Os pesos devem ser maiores ou iguais a zero.", exception.Message);
//     }

//     [Fact]
//     public void TirarMediaPonderada_QuandoValorANegativo_DeveLancarArgumentException()
//     {
//         // Arrange
//         MediaPonderada media = new();

//         // Act
//         Action act = () => media.TirarMediaPonderada(-10.0, 2.0, 3.5, 7.5);

//         // Assert
//         ArgumentException exception = Assert.Throws<ArgumentException>(act);
//         Assert.Equal("Os valores devem ser maiores ou iguais a zero.", exception.Message);
//     }

//     [Fact]
//     public void TirarMediaPonderada_QuandoValorBNegativo_DeveLancarArgumentException()
//     {
//         // Arrange
//         MediaPonderada media = new();

//         // Act
//         Action act = () => media.TirarMediaPonderada(10.0, -2.0, 3.5, 7.5);

//         // Assert
//         ArgumentException exception = Assert.Throws<ArgumentException>(act);
//         Assert.Equal("Os valores devem ser maiores ou iguais a zero.", exception.Message);
//     }

//     [Fact]
//     public void TirarMediaPonderada_QuandoValoresNegativos_DeveLancarArgumentException()
//     {
//         // Arrange
//         MediaPonderada media = new();

//         // Act
//         Action act = () => media.TirarMediaPonderada(-10.0, -2.0, 3.5, 7.5);

//         // Assert
//         ArgumentException exception = Assert.Throws<ArgumentException>(act);
//         Assert.Equal("Os valores devem ser maiores ou iguais a zero.", exception.Message);
//     }
// }
