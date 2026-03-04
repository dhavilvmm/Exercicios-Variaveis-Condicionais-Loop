using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o primeiro número: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int b = int.Parse(Console.ReadLine());

        if (a > b)
            Console.WriteLine("Maior: " + a);
        else if (b > a)
            Console.WriteLine("Maior: " + b);
        else
            Console.WriteLine("Números iguais");
    }
}