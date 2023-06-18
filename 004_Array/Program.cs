using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            // Métodos para Array
            
            // Declarando e inicializando um array de strings
            string[] nomes = new string[] { "Rafael", "Jonas", "Carlos", "Helena" };
            string[] copia = new string[4];
            copia = nomes;
            
            // Ordena o conteudo do array
           
            //Percorre um array
            //copia[1] = "Aline";
            Array.Sort(nomes);
            //Array.Clear(nomes, 0, 2);
            Console.WriteLine("Dados array nomes:");
            foreach (string item in nomes)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nDados array copia:");
            foreach (string item in copia)
            {
                Console.WriteLine(item);
            }

            // Copiar o conteudo do array nomes para o array nomesDuplicados

            /*
            string[] nomesDuplicados = new string[10];
            nomes.CopyTo(nomesDuplicados,1);
            nomesDuplicados[0] = "Ana";
            Console.WriteLine("\nCopia de Array: ");
            foreach (var item in nomesDuplicados)
            { 
                Console.WriteLine(item);
            }
            */

            /*
            string[] nomesClone = (string[])nomes.Clone();//clona um array
            nomes[0] = "Ana";
            Console.WriteLine(nomes[0]);
            Console.WriteLine(nomes[1]);
            Console.WriteLine(nomes[2]);
            */

            //inverte a sequencia dos elementos
            Console.WriteLine("\nMétodo Reverse");
            int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Array.Reverse(numeros);// Inverte a sequência dos elementos em todo o Array
            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadKey();
        }
    }
}
