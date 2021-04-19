 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_defined_Exceptions
{
    public class : Exception
    {
        public Out_of_range()
        {
            Console.WriteLine("Can't go beyond the limits");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 1, 2, 3, 4, 5 };


            try
            {
                for(int i = 0; i < 6;i ++)
                {
                    if(i > 4)
                    {
                        throw new Out_of_range();
                    }
                    else
                    {
                        Console.WriteLine(array[i]);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Went out of limit");
            }

            Console.ReadLine();
        }
    }
}
