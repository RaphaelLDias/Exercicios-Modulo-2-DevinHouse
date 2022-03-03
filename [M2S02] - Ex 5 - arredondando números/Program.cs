using System;

namespace ArredondandoNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número com duas casas após a virgula:");
            var numero = Console.ReadLine();
            var converteNumero = float.Parse(numero);
            
            Console.WriteLine($"O número arredondado é {numero}.");
        }
    }
}