using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite A: ");
        int A = int.Parse(Console.ReadLine());

        Console.Write("Digite B: ");
        int B = int.Parse(Console.ReadLine());

        Console.Write("Digite C: ");
        int C = int.Parse(Console.ReadLine());

        int R = (A + B) * (A + B);
        int S = (B + C) * (B + C);
        int D = R + S;

        Console.WriteLine("D = " + D);
    }
}