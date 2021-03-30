using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probka
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.ForegroundColor = ConsoleColor.Black;
            Random rand = new Random();
            int n = 300;
            char[,] a = new char[300, 300];
            while (true)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        a[i, j] = (char)rand.Next(0x0410, 0x44F);
                        Console.Write(a[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey(true);
        }
    }
}
