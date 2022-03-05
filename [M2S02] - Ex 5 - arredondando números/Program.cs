using System;

namespace ArredondandoNumeros
{
    class Program
    {
        static void Main()
        {
            float numero;
            Console.WriteLine("Digite um número com duas casas após a virgula:");
            numero = float.Parse(Console.ReadLine());
            int convertido = (int)Math.Round(numero);
            
            Console.WriteLine("O número arredondado é {0}.", convertido);
        }
    }
}