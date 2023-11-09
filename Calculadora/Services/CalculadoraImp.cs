namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        public int Soma(int a, int b)
        {
            return a + b;
        }

        public bool IsPar(int num)
        {
            return num % 2 == 0;
        }
    }
}