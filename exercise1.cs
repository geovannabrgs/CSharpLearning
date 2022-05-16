using System;
using System.Globalization;

namespace curso{
  class Program{
    static void Main(string[] args){
      double b, a, area, perimetro, diagonal;
      
      b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      
      area = b * a ;
      perimetro = 2 * (b + a);
      diagonal = Math.Sqrt(Math.Pow(b, 2.0) + Math.Pow(a, 2.0));
      
      Console.ReadLine();
    }
  }
}
