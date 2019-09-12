using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05B_Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra = 'a';
            Console.WriteLine(letra);

            char valor = (char)65;
            Console.WriteLine(valor);

            //valor = valor + 1; // Não compila
            valor = (char)(valor + 1);
            Console.WriteLine(valor);

            string palavra = "alura cursos online de tecnologia";
            Console.WriteLine(palavra);

            palavra = palavra + 2020;
            Console.WriteLine(palavra);

            Console.WriteLine("Aperte uma tecla para continuar. . .");
            Console.ReadKey();
        }
    }
}
