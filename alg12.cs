using System;

class Program
{
    static void Main(string[] args)
    {
        int soma = 0;
        int contador = 1;

        while (contador <= 5)
        {
            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine());
            soma += num;
            contador++;
        }

        Console.WriteLine("Soma total: " + soma);
    }
}