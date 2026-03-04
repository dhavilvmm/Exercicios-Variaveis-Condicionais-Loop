using System;

class Program
{
    static void Main(string[] args)
    {
        int pares = 0;
        int impares = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
                pares++;
            else
                impares++;
        }

        Console.WriteLine("Pares: " + pares);
        Console.WriteLine("Ímpares: " + impares);
    }
}