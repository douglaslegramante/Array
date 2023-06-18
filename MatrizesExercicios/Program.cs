using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizesExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio02();
            Console.ReadKey();
        }
        //Exercício 01
        static void Exercicio01()
        {
            Console.WriteLine("\t\tArmazena notas em uma matriz\n");

            int[,] notaAluno = new int[3, 4];
            double media, soma;

            for (int aluno = 0; aluno < 3; aluno++)
            {
                soma = 0;
                media = 0;
                Console.WriteLine("Informe a nota do {0}º aluno:\n", (aluno + 1));

                for (int nota = 0; nota < 4; nota++)
                {
                    Console.Write("Informe a nota do {0}º bimestre: ", (nota + 1));
                    notaAluno[aluno, nota] = int.Parse(Console.ReadLine());
                    soma += notaAluno[aluno, nota];
                }
                media = soma / 4;
                Console.Write("\nA média final do {0}º aluno  é: {1}", (aluno + 1), media);
                Console.WriteLine("\n");
            }
        }

        //Exercício 02
        static void Exercicio02()
        {
            int[,] numeros = new int[4, 5];
            int soma = 0;

            Console.WriteLine("\t\t---Matriz 4x5---\n");
            for (int linha = 0; linha < 4; linha++)
            {
                for (int coluna = 0; coluna < 5; coluna++)
                {
                    Console.Write("Informe o valor na posição [{0},{1}]: ", linha, coluna);
                    numeros[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }
            //Calcula a soma dos valores de cada coluna
            int[] somaValores = new int[5];
            for (int c = 0; c < 5; c++)
            {
                soma = 0;
                for (int l = 0; l < 4; l++)
                {
                    soma = numeros[l, c] + soma;
                }
                somaValores[c] = soma;
                Console.WriteLine("\nA soma da {0}º coluna é: {1}", (c + 1), somaValores[c]);
            }

        }
    }
}