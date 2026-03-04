using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o primeiro número: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Soma: " + (n1 + n2));
        Console.WriteLine("Subtração: " + (n1 - n2));
        Console.WriteLine("Multiplicação: " + (n1 * n2));

        if (n2 != 0)
            Console.WriteLine("Divisão: " + ((double)n1 / n2));
        else
            Console.WriteLine("Divisão impossível.");
    }
}