using System;

class exercicio07{
    static void Main(){
        int nota1, nota2, nota3; 
        float media;

        Console.WriteLine("Digite sua primeira nota:");
        nota1 = int.Parse (Console.ReadLine());

        Console.WriteLine("Digite sua segunda nota:");
        nota2 = int.Parse (Console.ReadLine());

        Console.WriteLine("Digite sua terceira nota:");
        nota3 = int.Parse (Console.ReadLine());

        media = (float)(nota1 + nota2 + nota3)/3;

        Console.WriteLine("Sua média final é:{0}.", media.ToString("F"));
    }
}