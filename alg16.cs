using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        int num = int.Parse(Console.ReadLine());

        int fatorial = 1;

        for (int i = 1; i <= num; i++)
        {
            fatorial *= i;
        }

        Console.WriteLine("Fatorial: " + fatorial);
    }
}