﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13E_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int linha = 0; linha < 10; linha++)
            {
                for (int coluna = 0; coluna < linha; coluna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
