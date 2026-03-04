using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nota 1: ");
        double n1 = double.Parse(Console.ReadLine());

        Console.Write("Nota 2: ");
        double n2 = double.Parse(Console.ReadLine());

        Console.Write("Nota 3: ");
        double n3 = double.Parse(Console.ReadLine());

        double media = (n1 * 2 + n2 * 3 + n3 * 5) / 10;
        Console.WriteLine("Média ponderada: " + media);
    }
}