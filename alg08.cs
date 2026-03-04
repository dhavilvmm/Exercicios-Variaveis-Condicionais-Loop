using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite três números: ");

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a > 0 && b > 0 && c > 0)
            Console.WriteLine("Soma: " + (a + b + c));
        else
            Console.WriteLine("Erro: todos devem ser positivos.");
    }
}