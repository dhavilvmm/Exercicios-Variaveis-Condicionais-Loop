using System;

class Program
{
    static void Main(string[] args)
    {
        int soma = 0;

        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Digite a idade " + i + ": ");
            int idade = int.Parse(Console.ReadLine());
            soma += idade;
        }

        double media = soma / 5.0;

        Console.WriteLine("Média das idades: " + media);
    }
}