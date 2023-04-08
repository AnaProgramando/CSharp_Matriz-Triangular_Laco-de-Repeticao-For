using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_LacoDeRepeticaoFor3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto - Imprimindo uma matriz triangular com For: \r\n");
            Console.WriteLine("____________________________________________________________________ \r\n");

            for (int linha = 0; linha < 10; linha++)
            {
                for (int coluna = 0; coluna <= linha; coluna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
