using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe o valor presente: ");
        double valorPresente = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe a taxa de juros a.a (em porcentagem, sem o sinal): ");
        double taxaJuros = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o periodo de anos: ");
        double anos = Convert.ToDouble(Console.ReadLine());

        double taxaFormatada = taxaJuros / 100;

        double montante = valorPresente * Math.Pow((1 + taxaFormatada), anos);

        Console.WriteLine($"Valor presente declarado: {valorPresente}");
        Console.WriteLine($"Taxa de juros declarada: {taxaJuros}");
        Console.WriteLine($"Periodo em anos declarado: {anos}");
        Console.WriteLine($"O montante ao final do periodo será: {montante:F2}, com rendimento total sendo: {montante - valorPresente:F2}");
    }
}
