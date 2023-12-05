using System;

class Program
{
    static void Main()
    {
        double valorPresente = 20000;
        double taxaJuros = 2.0 / 100;
        double mes = 1;
        double montante = 0;

        for (int i = 0; i < 6; i++)
        {
            montante = valorPresente * (1 + mes * taxaJuros);

            if (i >= 4) 
            {
                montante -= 2000;
            };

            Console.WriteLine($"No mês {i+1} o montante é: {montante:C}");
            mes++;
        }
    }
}