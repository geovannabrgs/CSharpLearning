using System;

namespace console1
{
    class Casting
    {
        static void Main(string[] args)
        {
            int a, b;
            double resultado;

            a = 5;
            b = 15;

            resultado = (double) a / b;

            Console.Write($"{resultado}");
        }
    }
}
