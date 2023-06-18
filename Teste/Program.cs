using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            //Declaração
            string[] produtos = new string[5];
            double[] valores = new double[5];
            int[] qtds = new int[5];
            double total = 0;

            //Leitura
            Console.WriteLine("\t\t---Sistema de Vendas 1.0---");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\nItem " + (i + 1));
                Console.Write("Produto: ");
                produtos[i] = Console.ReadLine();
                Console.Write("Valor: ");
                valores[i] = double.Parse(Console.ReadLine());
                Console.Write("Quantidade: ");
                qtds[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();

            //Impressão
            Console.WriteLine(" ------------------------------------------");
            Console.WriteLine("{0,27}", " CUPOM FISCAL ");
            Console.WriteLine(" ------------------------------------------");
            Console.WriteLine("{0,-15} {1,10}  {2,3} {3,10}", "PRODUTO", "UNITÁRIO", "QTD", "TOTAL");
            Console.WriteLine(" ------------------------------------------");
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0,-15} {1,10:C2}  {2:n2} {3,10:C2}", produtos[i], valores[i], qtds[i], (qtds[i] * valores[i]));
                total += (qtds[i] * valores[i]);
            }
            Console.WriteLine(" ------------------------------------------");
            Console.WriteLine($"Total: {total:c2}");
            Console.WriteLine(" ------------------------------------------");//43

            //Capturar data
            string data = DateTime.Now.ToShortDateString();
            //Capturar hora
            string hora = DateTime.Now.ToShortTimeString();

            Console.WriteLine("{0,1} {1,25}", "DATA: " + data, "HORA: " + hora);


            Console.ReadKey();
        }
    }
}
