﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12A_CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 12");

            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;
            int contadorAno;

            for (contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    valorInvestido *= fatorRendimento;
                }
                fatorRendimento += 0.0010;
            }

            Console.WriteLine("Tempo de investimento foi de " + --contadorAno + " ano(s).");
            Console.WriteLine("Ao término do investimento, você terá " 
                + valorInvestido.ToString("C", CultureInfo.CurrentCulture));

            Console.ReadLine();
        }
    }
}
