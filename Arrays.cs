using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // single dimension array
            int[] arr = new int[5]  { 111,222,333,444,555};

            for(int i = 0; i < arr.Length; i ++)
            {
                Console.WriteLine(arr[i]);
            }

            // matrix
            int[,] arr2 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for( int j = 0; j < arr.Length; j ++)
            {
                for( int k = 0; k < arr.Length; k ++)
                {
                    Console.WriteLine(arr[k]);
                }
            }

            // jagged array
            int[][] arr3 = new int[3][];

            arr3[0] = new int[3] { 1, 2, 3 };
            arr3[1] = new int[4] { 11, 22, 33, 44 };
            arr3[2] = new int[5] { 111, 222, 333, 444, 555 };
            
            for(int i = 0; i < arr3.Length; i ++)
            {
                for (int j = 0; j < arr3[i].Length; j++)
                {
                    Console.WriteLine(arr3[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
