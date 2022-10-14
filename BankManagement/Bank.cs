using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    internal class Bank
    {
        string Name, DOB, FatherName, Aadhar, Address;
        int InitialAmount = 0;
        int sub = 0, sum = 0;
        static int AccountNo = 1;
        static int ATMBalance;
        public static void SetATM()
        {
            ATMBalance = 500000;
        }
        public Bank()
        {
            Console.WriteLine(" Enter Your Name: ");
            Name = Console.ReadLine();
            Console.WriteLine(" Enter Your DOB: ");
            DOB = Console.ReadLine();
            Console.WriteLine(" Enter Your Father's Name: ");
            FatherName = Console.ReadLine();
            Console.WriteLine(" Enter Your Address: ");
            Address = Console.ReadLine();
            Console.WriteLine(" Enter Your AadharNo: ");
            Aadhar = Console.ReadLine();
            Console.WriteLine(" Enter Initial Amount : ");
            InitialAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Account has been Created. ");
            Console.Write("Dear Coustomer " + Name + "Your Account No is ");
            Console.WriteLine(AccountNo);
            AccountNo++;
            Console.WriteLine("Your Initial Amount is " + InitialAmount);
        }
        public void WithDraw()
        {
            Console.WriteLine("Enter the Amount: ");
            sub = Convert.ToInt32(Console.ReadLine());
            if (InitialAmount > sub)
            {
                InitialAmount = InitialAmount - sub;
                ATMBalance = ATMBalance - sub;
                Console.WriteLine(" Dear " + Name + "Your Balance Amount is " + InitialAmount);
                Console.WriteLine("ATM Balance : " + ATMBalance);
            }
            else
            {
                Console.WriteLine(" Your Balance is Low. ");
            }
        }
        public void Deposite()
        {
            Console.WriteLine("Enter the Amount: ");
            sum = Convert.ToInt32(Console.ReadLine());
            InitialAmount = InitialAmount + sum;
            Console.WriteLine(" Dear " + Name + " Your Balance After Deposit is " + InitialAmount);

        }
    }
}
