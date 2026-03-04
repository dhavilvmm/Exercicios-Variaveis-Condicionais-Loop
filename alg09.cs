using System;

class Program
{
    static void Main(string[] args)
    {
        int soma = 0;
        int i = 1;

        while (i <= 100)
        {
            soma += i;
            i++;
        }

        Console.WriteLine("Soma de 1 a 100: " + soma);
    }
}