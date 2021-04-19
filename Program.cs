using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Atm
    {
        int accno;
        int password;
        string name;
        int pin;
        float amount;
        

        Atm(int acc, int pass, int npin,float amot, string sname)
        {
            accno = acc;
            password = pass;
            pin = npin;
            name = sname;
            amount = amot;
          
        }

        void login()
        {
            Console.WriteLine("Enter the pin");
            int p = Convert.ToInt32(Console.ReadLine());

            if(pin == p)
            {
                Console.WriteLine("Pin is valid\n");
            }
            else
            {
                Console.WriteLine("Invalid\n");
            }

        }

        void check_balance()
        {


            Console.WriteLine("Enter the pin To check your balance ");
            int p = Convert.ToInt32(Console.ReadLine());

            if (pin == p)
            {
                Console.WriteLine("Balance "  + amount);
            }
            else
            {
                Console.WriteLine("Sorry you can't check your balance");
            }
        }
        static void Main(string[] args)
        {
            Atm obj = new ConsoleApplication3.Atm(2021, 81, 7777, 14000.00F, "Neha");
            obj.login();
            obj.check_balance();

            Console.ReadLine();
        }
    }
}
