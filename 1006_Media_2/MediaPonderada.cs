using System;

public class MediaPonderada
{
    public double TirarMediaPonderada(double valorA, double valorB, double valorC, double pesoA, double pesoB, double pesoC)
    {
       return (valorA * pesoA + valorB * pesoB + valorC * pesoC) / (pesoA + pesoB + pesoC);
    }
}
