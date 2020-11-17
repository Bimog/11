using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] mas = new int[2, 2];
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = rnd.Next(0, 9);
                }
            }                    
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write(mas[i, j] + "");
                }
                Console.WriteLine();
            }       
            int n = 0; 
            bool indikator;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                indikator = true;
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (mas[i, j] == 0)
                    {
                        indikator = false;
                    }
                }
                if (indikator) { n++; }
            }


            Console.WriteLine("количество ненулевых строк = " + n);

        }
        private static Random rnd = new Random();
    }
}