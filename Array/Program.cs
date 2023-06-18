using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {            
            
            int[] notas = new int[10];
            double media = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write("Informe a {0}ª nota : ", i + 1);
                int nota = int.Parse(Console.ReadLine());
                notas[i] = nota;
                media = media + nota;
            }
            //for (int i = 0; i < notas.Length; i++)
            //{
            //    Console.WriteLine("{0}ª nota: {1}", i + 1, notas[i]);
            //}

            int k = 1;
            foreach (var item in notas)
            {
                Console.WriteLine("{0}ª nota: {1}", k, item);
                k++;
            }

            Console.WriteLine("\nMédia de notas: "+media/notas.Length);


            int[] valores; // declaração
            valores = new int[10]; // inicialização

            int[] numeros = new int[10]; // declaração e inicialização

            numeros[1] = 7; // atribuindo valor no indice 1
                            //Console.WriteLine(numeros[1]);
            int j =0;
            foreach (var item in numeros)
            {
                Console.WriteLine("numero {0}: {1}", j, item);
                j++;
            }          

            //foreach (var item in numeros)
            //{
            //    Console.WriteLine(item); // imprimindo
            //}
            


            int[] numero = { 100, 34, 55,34,98,21 }; 
            int[] number = numero;

            numero[3] = 66;
            
           
            Console.WriteLine(numero.Contains(51)); //verifica se contem um determinado valor
            Console.WriteLine(numero.Length);//retorna o numero total de elementos

            foreach (var item in numero)
            {
                Console.WriteLine(item);
            }
            System.Array.Clear(numero, 4, 1);// limpa o valor de um elemento
            Console.WriteLine("apagou? ");

            foreach (var item in numero)
            {
                Console.WriteLine(item);
            }
            var tipo = new[] {1,2,3,4};
            var teste = new[] { "Abc", "Bcd", "Cde" };
            var test = new[] { 'a', 'b', 'c' };

            Console.WriteLine(numero);
            Console.ReadKey();
            
        }
    }
}
