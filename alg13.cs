using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o primeiro número: ");
        double n1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double n2 = double.Parse(Console.ReadLine());

        Console.Write("Digite a operação (+, -, *, /): ");
        string op = Console.ReadLine();

        switch (op)
        {
            case "+":
                Console.WriteLine("Resultado: " + (n1 + n2));
                break;
            case "-":
                Console.WriteLine("Resultado: " + (n1 - n2));
                break;
            case "*":
                Console.WriteLine("Resultado: " + (n1 * n2));
                break;
            case "/":
                if (n2 != 0)
                    Console.WriteLine("Resultado: " + (n1 / n2));
                else
                    Console.WriteLine("Divisão por zero.");
                break;
            default:
                Console.WriteLine("Operação inválida.");
                break;
        }
    }
}