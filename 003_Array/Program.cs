using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            //Imprime alfabeto
            char[] alfabeto = new char[26];//0, 1, 2, 3 ... 25

            for (int i = 0; i < alfabeto.Length; i++)
            {
                alfabeto[i] = Convert.ToChar(65 + i);
                //Console.WriteLine(alfabeto[i]);
            }

            foreach (var item in alfabeto)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
