using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика6
{
    class Program
    {
        static void Show (double[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write(string.Format("{0,3}", arr[i, j]));
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static double[,] Reverse(double [,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1)/2; j++)
                {
                    if (i % 2 == 0)
                    {
                        double temp = arr[i, j];
                        arr[i, j] = arr[i, arr.GetLength(1) - 1 - j];
                        arr[i, arr.GetLength(1) - 1 - j] = temp;
                    }
                }
            }
            return arr;
        }
    
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            double[,] arr = new double[8, 8];
            double k = 1;
            for (int i =0; i<8; i++)
                for (int j=0; j<8; j++)
                {
                    arr[i, j] = k;
                    k++;
                }
            Show(arr);
            arr = Reverse(arr);
            Show(arr);
            Console.ReadKey();
        }
    }
}
