public class VendaPeca
{
    public float DefinirValor(float valorPeca1, float valorPeca2, int contPeca1, int contPeca2)
    {
        if (valorPeca1 < 0 || valorPeca2 < 0 || contPeca1 < 0 || contPeca2 < 0)
        {
            throw new Exception("Os valores das peças e as quantidades devem ser não negativos.");
        }
        if (contPeca1 == 0 && contPeca2 == 0)
        {
            throw new Exception("A quantidade de pelo menos uma peça deve ser maior que zero.");
        }

        return (contPeca1 * valorPeca1) + (contPeca2 * valorPeca2);
    }
}
