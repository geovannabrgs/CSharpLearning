using System;
using System.Globalization;

namespace curso{
  class Program{
    static void Main(string[] args){

    string nome1, nome2;
    int idade1, idade2;
    double media;
    string[] vet;

    vet = Console.ReadLine().Split(' ');
    nome1 = vet[0];
    idade1 = int.Parse(vet[1]);

    vet = Console.ReadLine().Split(' ');
    nome2 = vet[0];
    idade2 = int.Parse(vet[1]);

    media = (idade1 + idade2) / 2;

    Console.ReadLine();
    }
  }
}
