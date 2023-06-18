using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            //Declaração e inicialização
            int[] numeros = new int[10];

            //Percorrendo um Array
            //Atribuindo valores

            double media = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Informe o {0}º valor: ", i + 1);
                numeros[i] = int.Parse(Console.ReadLine());
                media = media + numeros[i];
            }
            Console.WriteLine();

            //Acessando os valores com o Foreach
            Console.WriteLine();
            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nMédia: " + (media / numeros.Length));

            //Principais Propriedades
            Console.WriteLine("\no Array possui tamnho fixo?: " + numeros.IsFixedSize); //retorna um valor indicando se um array possui um tamanho fixo ou não
            Console.WriteLine("\no Array é somente leitura?: " + numeros.IsReadOnly); //retorna um a valor indicando se um array é somente-leitura ou não
            Console.WriteLine("\nQual o tamanho do Array? " + numeros.Length); //retorna o numero total de elementos.
            Console.WriteLine("\nQuantas dimensões tem o Array? " + numeros.Rank); //retorna o número de dimensões de um array
            

            //Principais Métodos
            Console.WriteLine("\nContém o valor 10? " + numeros.Contains(10)); //verifica se contém um determinado valor

            string[] nomes = new string[] { "rafael", "jonas", "marcelo" };
            Array.Sort(nomes); // ordenar um Array
            

            Console.WriteLine("\nNomes após o Sort");
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }

            string[] nomesCopia = new string[10];
            nomes.CopyTo(nomesCopia, 0); //copiar o conteúdo de um array para outro com maior capacidade
            string[] nomesClone = (string[])nomes.Clone(); //clona um array
            string[] nomesCopy = nomes; // não é uma cópia

            Array.Clear(nomes, 0, 1);// limpa o valor de um elemento

            Console.WriteLine("\nArray nomes após limpeza");
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("\nArray CopyTo");
            foreach (string nome in nomesCopia)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("\nArray Clone");
            foreach (string nome in nomesClone)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("\nArray copiado");
            foreach (string nome in nomesCopy)
            {
                Console.WriteLine(nome);
            }

            Array.Reverse(numeros); // Inverte a sequência dos elementos em todo o Array
            Console.WriteLine("\nImprimindo os numeros após o reverse");
            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
