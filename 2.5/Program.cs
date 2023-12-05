using System;

class Program 
{
    static void Main()
    {
        double valorFuturo = 7390.61;
        double taxaDeJuros = 1.25 / 100;
        double anos = 2;
        double valorPresente = 0;

        valorPresente = valorFuturo / Math.Pow((1 + taxaDeJuros), anos);

        Console.WriteLine($"O valor presente deve ser: {valorPresente:C}");
    }
}