using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrizes_Desafio
{
    class Program
    {
        static void Main(string[] args)
        {                    
            
            int[,] matriz_pulsacoes = new int[24, 4];

            for (int lin = 0; lin < 24; lin++)
            {
                Console.WriteLine("\t\t---Leitura de pusações na {0}ª hora---\n", (lin + 1));

                for (int col = 0; col < 4; col++)
                {
                    Console.Write("Paciente {0}: ", (col + 1));
                    matriz_pulsacoes[lin, col] = int.Parse(Console.ReadLine());
                }
            }

            double media = 0;
            double maiorMedia = 0;
            int cama = 0;
            int soma = 0;
            for (int col = 0; col < 4; col++)
            {
                for (int lin = 0; lin < 24; lin++)
                {
                    soma = soma + matriz_pulsacoes[lin, col];
                }
                media = soma / 24;
                Console.WriteLine("Media das pulsações do paciente da cama " + (col + 1) + " = " + media);
                if (maiorMedia < media)
                {
                    maiorMedia = media;
                    cama = col;
                }
                soma = 0;
                media = 0;
            }
            Console.WriteLine("A Maior media de pulsacoes= " + maiorMedia + " cama= " + (cama + 1));

            //maior valor
            cama = 0;
            int maior = 0;
            int hora = 0;
            for (int col = 0; col < 4; col++)
            {
                for (int lin = 0; lin < 24; lin++)
                {
                    if (maior < matriz_pulsacoes[lin, col])
                    {
                        maior = matriz_pulsacoes[lin, col];
                        cama = col;
                        hora = lin;
                    }
                }
            }
            Console.WriteLine("Maiores pulsacoes= " + maior + " cama= " + (cama + 1) + " horas= " + (hora + 1));
            
        }
    }
}
