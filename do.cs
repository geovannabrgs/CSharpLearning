using System;

string texto;

do {
    texto = Console.ReadLine();
    Console.WriteLine(texto);
}while(!string.IsNullOrEmpty(texto));
