public class Somar
{
    public int Somando(int A, int B)
    {
        if (A < 0 || B < 0)
        {
            throw new Exception("A e B devem ser maiores que 0");
        }
        else
        {
            return A + B;
        }
    }
}
