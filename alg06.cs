using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite três números diferentes:");

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int maior = a;

        if (b > maior) maior = b;
        if (c > maior) maior = c;

        Console.WriteLine("Maior número: " + maior);
    }
}