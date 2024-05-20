using System;

public class MediaPonderada
{
    public string TirarMediaPonderada(string valorA, string valorB, string pesoA, string pesoB)
    {
        if (
            string.IsNullOrEmpty(valorA)
            || string.IsNullOrEmpty(valorB)
            || string.IsNullOrEmpty(pesoA)
            || string.IsNullOrEmpty(pesoB)
        )
        {
            throw new ArgumentException("Os valores não podem ser nulos ou vazios.");
        }

        if (
            !double.TryParse(valorA, out double valorAParse)
            || !double.TryParse(valorB, out double valorBParse)
            || !double.TryParse(pesoA, out double pesoAParse)
            || !double.TryParse(pesoB, out double pesoBParse)
        )
        {
            throw new ArgumentException("Os valores devem ser numéricos.");
        }
        else
        {
            double valorADouble = valorAParse;
            double valorBDouble = valorBParse;
            double pesoADouble = pesoAParse;
            double pesoBDouble = pesoBParse;

            if (pesoADouble <= 0 || pesoBDouble <= 0)
            {
                throw new ArgumentException("Os pesos devem ser maiores que zero.");
            }
            if (valorADouble < 0 || valorADouble > 10 || valorBDouble < 0 || valorBDouble > 10)
            {
                throw new ArgumentException("Os valores devem estar entre 0 e 10.");
            }

            double media =
                (valorADouble * pesoADouble + valorBDouble * pesoBDouble)
                / (pesoADouble + pesoBDouble);
            return media.ToString();
        }
    }
}
