using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int numeroAlunos = 0;
            double somaNotas = 0;
            double media = 0;
            int pesquisar;

            Console.Write("Informe o numero de alunos: ");
            numeroAlunos = int.Parse(Console.ReadLine());

            double[] m1s = new double[numeroAlunos];
            double[] m2s = new double[numeroAlunos];
            double[] mf = new double[numeroAlunos];


            Console.WriteLine();
            for (int i = 0; i < numeroAlunos; i++)
            {
                Console.Write("Informe a média do 1º semestre do aluno {0}: ",(i + 1));
                m1s[i] = int.Parse(Console.ReadLine());
                Console.Write("Informe a média do 2º semestre do aluno {0}: ",(i + 1));
                m2s[i] = int.Parse(Console.ReadLine());

                mf[i] = (m1s[i] + m2s[i]) / 2;
            }

            Console.WriteLine("\n---Pesquisa média no array---");
            Console.WriteLine("\nInforme o código do aluno entre 1 e "+ mf.Length);
            pesquisar = int.Parse(Console.ReadLine());

            Console.WriteLine("\nA média do aluno pesquisado foi: " +mf[pesquisar -1]);
            */



            //string[] nomes = new string[5];
            //for (int i = 0; i < nomes.Length; i++)
            //{
            //    Console.Write("Informe o nome no indice "+i + ": ");
            //    nomes[i] = Console.ReadLine();
            //}
            //Console.WriteLine("\nImprimindo os dados do array:\n");
            //foreach (string item in nomes)
            //{
            //    Console.WriteLine(item);
            //}


            //Percorrendo Array com for

            int[] numeros = new int[101];

            for (int i = 0; i < 101; i++)
            {
                numeros[i] = i;
            }
            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Console.WriteLine(numeros[i]);
            //}

            /*
            Console.WriteLine("Aqui começa o foreach");
            
            // Percorrendo Array com foreach
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
            */
            Console.ReadKey();
        }
    }
}
