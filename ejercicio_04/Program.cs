using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un número: ");
            int numero = int.Parse(Console.ReadLine());


            for (int i = 0; i < numero; i++)
            {
                for (int j = 0; j < numero; j++)
                {
                    Console.Write("**");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            Console.Write("Ingresa un número: ");
            int numer0 = int.Parse(Console.ReadLine());


            for (int i = 0; i < numer0; i++)
            {
                for (int j = 0; j < numer0; j++)
                {
                    Console.Write("**");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

            
            Console.Write("Ingresa un número: ");
            int numb = int.Parse(Console.ReadLine());


            for (int i = 0; i < numb; i++)
            {
                for (int j = 0; j < numb; j++)
                {
                    Console.Write("**");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
