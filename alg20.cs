using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        double num = double.Parse(Console.ReadLine());

        Console.WriteLine("Dobro: " + (num * 2));
        Console.WriteLine("Triplo: " + (num * 3));
        Console.WriteLine("Raiz quadrada: " + Math.Sqrt(num));
    }
}