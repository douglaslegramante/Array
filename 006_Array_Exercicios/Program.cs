using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Array_Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio04();
            Console.ReadKey();
        }

        //Exercício 01
        static void Exercicio01()
        {
            int i = 0;
            int valor;
            int[] num = new int[5];

            while (i < 5)
            {
                Console.Write("Informe um valor entre '10' e '50': ");
                valor = int.Parse(Console.ReadLine());
                if (valor >= 10 && valor <= 50)
                {
                    num[i] = valor;
                    i++;
                }
                else
                {
                    Console.WriteLine("\nO valor deve estar entre '10' e '50'." +
                        " Informe um valor válido!\n");
                }

            }
            Console.WriteLine("\nO array 'num' contém " + num.Length + " elementos:");
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
        }


        // Exercício 02
        static void Exercicio02()
        {
            int[] x = new int[10];

            for (int i = 0; i < x.Length; i++) //0,1,2,3,..., 9
            {
                Console.Write("Informe o " + (i + 1) + "º valor: ");
                x[i] = int.Parse(Console.ReadLine());
            }

            int[] y = new int[10];
            x.CopyTo(y, 0);
            //int[] y = (int[])x.Clone();
            Array.Reverse(y);

            Console.WriteLine("Array 'X'");
            foreach (var itemX in x)
            {
                Console.WriteLine(itemX);
            }

            Console.WriteLine("Array 'Y'");
            foreach (var itemY in y)
            {
                Console.WriteLine(itemY);
            }
        }

        // Exercício 03
        static void Exercicio03()
        {
            int valor;
            int[] x = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("\n\t\tPesquisar no array!");
            Console.Write("\nInforme o valor: ");
            valor = int.Parse(Console.ReadLine());

            Console.WriteLine(x.Contains(valor));
            int indice = Array.IndexOf(x, valor);
            if (indice == -1)
            {
                Console.WriteLine("\nValor não encontrado!");
            }
            else
            {
                Console.WriteLine("\nO valor está no indice: " + indice);
            }
        }

        // Exercício 04
        static void Exercicio04()
        {
            int[] a = new int[10];
            int x;

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Informe o " + (i + 1) + "º valor: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n\t\tPesquisar no array!");
            Console.Write("\nInforme o valor: ");
            x = int.Parse(Console.ReadLine());

            if (a.Contains(x))
            {
                Console.WriteLine("\nACHEI!");
            }
            else
            {
                Console.WriteLine("\nNÃO ACHEI!");
            }
        }
    }
}

