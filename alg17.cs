using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("Divisores:");

        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
                Console.WriteLine(i);
        }
    }
}