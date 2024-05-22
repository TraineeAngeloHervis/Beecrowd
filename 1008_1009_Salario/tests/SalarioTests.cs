using Xunit;

public class SalarioTests {
    [Fact]
    public void Comissao_QuandoValoresPassados_DeveRetornarComissao() {
        // Arrange
        Salario salario = new();
        float valorVendas = 1230;

        // Act
        float comissao = salario.CalcularComissao(valorVendas);

        // Assert
        Assert.Equal(184.5f, comissao);
    }

    [Fact]
    public void SalarioHora_QuandoValoresPassados_DeveRetornarSalarioHora() {
        // Arrange
        Salario salario = new();
        int horasTrabalhadas = 40;
        float salarioHora = 10;

        // Act
        float salarioHoraCalculado = salario.CalcularSalarioHora(horasTrabalhadas, salarioHora);

        // Assert
        Assert.Equal(400, salarioHoraCalculado);
    }
}