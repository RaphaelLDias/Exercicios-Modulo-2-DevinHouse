using System;

namespace NomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {

            var nota1 = 8;
            var nota2 = 5;
            var nota3 = 6;

            var media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine($"O resultado é {media}.");
        }
    }
}