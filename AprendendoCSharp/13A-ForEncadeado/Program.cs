using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13A_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 13");

            // Output:
            // * 
            // **
            // ***
            // ****
            // *****
            // ******
            // *******
            // ********

            // FORMA 01
            for (int linha = 1; linha <= 8; linha++)
            {
                for (int coluna = 1; coluna <= linha; coluna++)
                    Console.Write("*");

                Console.WriteLine();
            }

            // FORMA 02
            for (int linha = 1; linha <= 8; linha++)
            {
                for (int coluna = 1; coluna <= 8; coluna++)
                {
                    Console.Write("*");
                    if (coluna >= linha)
                        break;
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
