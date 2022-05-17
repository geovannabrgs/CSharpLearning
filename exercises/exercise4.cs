using System;

namespace console1
{
    class Trapezio
    {
        static void Main(string[] args)
        {
            double area, baseMenor, baseMaior, h;

            baseMenor = 6.0;
            baseMaior = 8.0;
            h = 5.0;
            area = (baseMenor + baseMaior) / 2.0 * h;

            Console.Write($"{area}");
        }
    }
}
