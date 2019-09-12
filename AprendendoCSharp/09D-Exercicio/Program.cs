using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09D_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 3300.0;

            if (1900.0 <= salario && salario <= 2800.0)
            {
                Console.WriteLine("O IR é de 7.5%");
                Console.WriteLine("Pode deduzir R$ 142");
            }
            else if (2800.01 <= salario && salario <= 3751.0)
            {
                Console.WriteLine("O IR é de 15%");
                Console.WriteLine("Pode deduzir R$ 350");

            }
            else if (3751.01 <= salario && salario <= 4664.0)
            {
                Console.WriteLine("O IR é de 22.5%");
                Console.WriteLine("Pode deduzir R$ 636");
            }

            Console.ReadKey();
        }
    }
}
