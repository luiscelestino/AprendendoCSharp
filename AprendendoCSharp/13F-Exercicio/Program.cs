using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13F_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            // FORMA 01
            for (int numero = 1; numero <= 100; numero++)
            {
                if (numero % 3 == 0)
                {
                    Console.WriteLine(numero);
                }
            }

            // FORMA 02
            for (int numero = 3; numero <= 100; numero += 3)
            {
                Console.WriteLine(numero);
            }


            Console.ReadKey();
        }
    }
}
