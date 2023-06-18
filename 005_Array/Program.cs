using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
                      
            // Array multidimensional

            // Inicialização
            /*Array bidimensional retangular.
             * A quantidade de dimensões é igual à quantidade de vírgulas
             * definidas dentro dos colchetes mais um
             */
            //int[,] retangular;

            /*Array bidimensional irregular.
            * A quantidade de dimensões é igual à quantidade de pares de colchetes.
            */
            //int[][] irregular;

            // Declaração
            //int[,] x; // bidimensional retangular
            //int[,,] y; // tridimensional retangular
            //int[,,,] z; // quadridimensional retangular

            //int[][] a; // bidimensional irregular
            //int[][][] b; // tridimensional irregular
            //int[][][][] c; // quadridimensional irregular

            // Inicialização
            int[,] num = new int[3, 4];
            int soma = 0;
            double media = 0;
            
            for (int linha = 0; linha < 3; linha++)
            {
                
                soma = 0;
                Console.WriteLine("\nInforme as notas do {0}º aluno\n",linha+1 );
                for (int coluna = 0; coluna < 4; coluna++)
                {
                    Console.Write("Informe a nota do {0}º bimestre: ", coluna+1);
                    num[linha, coluna] = int.Parse(Console.ReadLine());
                    soma = soma + num[linha, coluna];
                }
                media = soma / 4;
                Console.WriteLine("A média final do aluno é: {0:n2}", media);
            }


            for (int i = 0; i <3 ; i++)
            {
                Console.WriteLine("\n\t\tNotas");
                Console.WriteLine("Notas do {0}º aluno", i+1);

                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Nota do {0}º bimestre: {1}",j+1, num[i,j]);
                }
            }

            /*
            int[][] numeros = new int[3][];
            numeros[0] = new int[3];
            numeros[1] = new int[5];
            numeros[2] = new int[7];

            int[,] valor = new int[3, 4]
            {
                { 0, 1, 2, 3}, // inicialização do Índice de número de linhas 0
                { 4, 5, 6, 7}, // inicializar um número de índice de linha 1
                { 8, 9, 10, 11} // inicializar o número de índice para a linha 2
            };

            // Acesso
            num[0, 1] = 5;
            num[0, 2] = 7;
            num[0, 3] = 9;

            numeros[0][0] = 4;
            numeros[1][1] = 6;
            numeros[2][2] = 8;

            // Impressão
            //for (int linha = 0; linha < 5; linha++)
            //{
            //    for (int coluna = 0; coluna < 10; coluna++)
            //    {
            //        Console.WriteLine(linha + " " + coluna + " = " + num[linha, coluna]);
            //    }
            //}

            for (int i = 0; i < numeros.Length; i++)
            {
                for (int j = 0; j < numeros[i].Length; j++)
                {
                    Console.WriteLine(i + " " + j + " = " + numeros[i][j]);
                }
            }
            */
            Console.ReadKey();
        }
    }
}
