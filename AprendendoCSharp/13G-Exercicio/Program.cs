using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13G_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            // FORMA 01
            int fatorial;

            for (int n = 1; n <= 10; n++)
            {
                fatorial = 1;

                for (int i = 1; i <= n; i++)
                {
                    fatorial *= i;
                }
                Console.WriteLine(n + "! = " + fatorial);
            }

            // FORMA 02
            fatorial = 1;
            for (int i = 1; i <= 10; i++)
            {
                fatorial *= i;
                Console.WriteLine(i + "! = " + fatorial);
            }

            Console.ReadKey();
        }
    }
}
