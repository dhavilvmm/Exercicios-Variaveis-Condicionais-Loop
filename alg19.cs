using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        int num = int.Parse(Console.ReadLine());

        if (num <= 1)
        {
            Console.WriteLine("Não é primo.");
            return;
        }

        bool primo = true;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                primo = false;
                break;
            }
        }

        if (primo)
            Console.WriteLine("É primo.");
        else
            Console.WriteLine("Não é primo.");
    }
}