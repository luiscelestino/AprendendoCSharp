using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04A_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario = 1200.50;

            // o int é um tipo de variável de 32 bits
            int salarioEmInteiro = (int) salario;
            Console.WriteLine(salarioEmInteiro);

            // O long é um tipo de variável de 64 bits
            long idade = 13000000000;
            Console.WriteLine(idade);

            // o short é um tipo de variável de 16 bits
            short quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80F;
            Console.WriteLine(altura);

            Console.ReadLine();
        }
    }
}
