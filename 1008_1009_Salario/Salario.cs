public class Salario
{
    public float CalcularSalarioHora(int horasTrabalhadas, float salarioHora)
    {
        return horasTrabalhadas * salarioHora;
    }

    public float CalcularComissao(float valorVendas)
    {
        return valorVendas * 0.15f;
    }
}
