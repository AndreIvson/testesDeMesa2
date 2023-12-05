using System;

class Program
{
    static void Main() 
    {
        double[] valores = new double[6];
        double valorPresente = 3800;
        double taxaJuros = 1.25 /100;
        double meses = 1;
        double montante = 0;
        double rendimentoLiquido = 0;
        
        
        for (int i = 0; i < 6; i++)
        {
            montante = valorPresente * Math.Pow((1 + taxaJuros), meses);
            rendimentoLiquido = montante - valorPresente;
            Console.WriteLine($"Mês {i + 1}, rendimento= {montante:F2}, rendimento liquido= {rendimentoLiquido:F2}");
            meses++;
        }
    }

}