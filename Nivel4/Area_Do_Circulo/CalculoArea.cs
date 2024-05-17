public class CalculoArea
    {
        private const double PI = 3.14159;

        public double CalcularArea(double raio)
        {
            double raioQuadrado = Math.Pow(raio, 2);
            return raioQuadrado * PI;
        }
    }