using System;

class Program
{
    static void Main()
    {
        double valorPresente = 1000;
        double taxaJuros = 5.30 / 100;
        double periodoMes = 6;
        double anos = 2;
        double rendimentoMes = 0;
        double rendimentoAno = 0;

        rendimentoMes = valorPresente * Math.Pow((1 + taxaJuros), periodoMes);

        rendimentoAno = valorPresente * Math.Pow((1 + taxaJuros), (anos * 12));

        string rendimentoMesFixed  = rendimentoMes.ToString("F2");
        string rendimentoAnoFixed  = rendimentoAno.ToString("F2");

        Console.WriteLine($"O rendimento total após {periodoMes} meses é {rendimentoMesFixed}");
        Console.WriteLine($"O rendimento total após {anos} anos é {rendimentoAnoFixed}");
    }
}

