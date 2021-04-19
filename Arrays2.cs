using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
{
    class Program
    {
        //malloc() -> new {used for memory allocation}
        //malloc(sizeof(int)
        static void Main(string[] args)
        {
            //int[] arr = new int[5] { 2, 3, 4, 5, 6 };

            //// traversing
            //for(int i = 0; i < 5; i ++)
            //{
            //    Console.WriteLine(arr[i]);
            
            //}

          //   0  1
          //_________
          //0 | 1  2
          //1 | 3  4  4

            //1) 0,0 
            //2) 0,1
            //3) 1,0
            //4) 1,1

            //1) row must not be changed unless and untill all the coloms are traversed

            //int[,] arr = new int[2, 2] { { 1, 2 }, { 3, 4 } };

            //for(int i = 0; i < 2; i ++)
            //{
            //    for(int j = 0; j < 2; j++)
            //    {
            //        Console.WriteLine(arr[i, j]);
            //    }
            //}

            int[][] arr = new int[3][];

            arr[0] = new int[3] { 2, 3, 4 };
            arr[1] = new int[2] { 9, 8 };
            arr[2] = new int[1] { 7 };

             //{ 2, 3, 4 };
             //{ 9, 8 };
             //{ 7 };

            //row.length to tell the compiler the size of row [no of elements in a row]
            for(int row = 0; row < 3; row++)
            {
                //1) always starts from zero
                //2) auto increment
                //3) coloum = arr[1];

                foreach (int coloumn in arr[row])
                {
                    Console.WriteLine(coloumn);
                }
            }
            Console.ReadLine();
        }

    }
}
