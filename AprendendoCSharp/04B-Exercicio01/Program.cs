﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04B_Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            // float é 32 bits
            float pontoFlutuante = 3.14f;
            
            // double é 64 bits
            double salario = 1270.50;
            int valor = (int) salario;
            Console.WriteLine(valor);

            double valor1 = 0.2;
            double valor2 = 0.1;
            double total = valor1 + valor2;
            Console.WriteLine(total);

            Console.WriteLine("Tecle algo para continuar. . . ");
            Console.ReadKey();
        }
    }
}
