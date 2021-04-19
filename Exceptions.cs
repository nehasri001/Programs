using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 1, 2, 3, 4, 5 };

            for (int i = 0; i < 6; i++)
            {

                //code prone to error is written in try block
                try
                {
                    Console.WriteLine(array[i]);
                }


                //code to handle the exception is written in catch block
                catch (Exception e)
                {
                    Console.WriteLine("Size of array exceeded");
                }
            }

            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int divisor, dividend;

            divisor = 0;
            dividend = 20;

            try
            {
                Console.WriteLine(dividend / divisor);
            }
            catch (Exception e)
            {
                Console.WriteLine("Division by zero not possible");
            }

            Console.ReadLine();
        }
    }
}

