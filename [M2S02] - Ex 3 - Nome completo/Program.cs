using System;

namespace NomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é seu nome?");
            var nome = Console.ReadLine();
            Console.WriteLine("Qual é seu sobrenome?");
            var sobrenome = Console.ReadLine();
            Console.WriteLine($"Seu nome completo é {nome} {sobrenome}.");
        }
    }
}