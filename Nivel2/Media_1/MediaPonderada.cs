using System;

public class MediaPonderada
{
    public double TirarMediaPonderada(double valorA, double valorB, double pesoA, double pesoB)
    {
        if (pesoA <= 0 || pesoB <= 0)
        {
            throw new ArgumentException("Os pesos devem ser maiores que zero.");
        }
        if (valorA < 0 || valorA > 10 || valorB < 0 || valorB > 10)
        {
            throw new ArgumentException("Os valores devem estar entre 0 e 10.");
        }

        return (valorA * pesoA + valorB * pesoB) / (pesoA + pesoB);
    }
}
