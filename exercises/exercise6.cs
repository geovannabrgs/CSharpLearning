using System;
class Media {
  static void Main(string[] args) {
      double n1, n2, media;
      
    Console.WriteLine("Digite um número: ");
    n1 = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite outro número: ");
    n2 = double.Parse(Console.ReadLine());
    
    media = (n1 + n2) / 2.0;
    
    Console.WriteLine($"Media = {media}");
  }
}
