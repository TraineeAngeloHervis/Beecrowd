using System;

public class MediaPonderada
{
    public double TirarMediaPonderada(double valorA, double valorB, double pesoA, double pesoB)
    {
       return (valorA * pesoA + valorB * pesoB) / (pesoA + pesoB);
    }
}
