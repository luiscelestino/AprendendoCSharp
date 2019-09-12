using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11A_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 11");

            double valorInvestido = 1000;

            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvestido *= 1.0036;
                Console.WriteLine("Após " + contadorMes + " meses, você terá R$ " + valorInvestido);
                Console.WriteLine("Após " + contadorMes + " meses, você terá "
                    + valorInvestido.ToString("C", CultureInfo.CurrentCulture));
                Console.WriteLine("Após " + contadorMes + " meses, você terá "
                    + valorInvestido.ToString("C", CultureInfo.CreateSpecificCulture("fr-CA")));
                Console.WriteLine("Após " + contadorMes + " meses, você terá "
                    + valorInvestido.ToString("C", CultureInfo.CreateSpecificCulture("en-CA")));
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
