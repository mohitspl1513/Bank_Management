using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Bank> Customer = new List<Bank>();
            string ch;
            int Choice, Press;
            do
            {
                Console.WriteLine("Do You want to Create New Account : Y/N");
                ch = Console.ReadLine();
                if (ch.Equals("Y"))
                {
                    Bank obj = new Bank(); // Constructor Has Been called
                    do
                    {
                        Console.WriteLine("1.WithDraw ");
                        Console.WriteLine("2.Deposit ");
                        Console.WriteLine("3.Exit ");
                        Console.WriteLine("Enter Your Choice");
                        Choice = Convert.ToInt32(Console.ReadLine());
                        if (Choice == 1)
                        {
                            obj.WithDraw();
                        }
                        else if (Choice == 2)
                        {
                            obj.Deposite();
                        }
                        else
                        {
                            break;
                        }

                        Console.WriteLine(" Do you want to continue : \n Press: 1 for Continue \n Press 0 for Exit");
                        Press = Convert.ToInt32(Console.ReadLine());
                    } while (Press == 1);

                    Customer.Add(obj);
                }
                else
                {
                    Console.WriteLine("Enter a Valid Choice ");
                }
            } while (ch.Equals("Y"));
        }
    }
}
