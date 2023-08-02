using System;
using System.Diagnostics.SymbolStore;

namespace Regexs
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.pincode\n2.email");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice) 
                {
                    case 1:
                        PinCode pinCode = new PinCode();
                        break;
                    case 2:
                        Email email = new Email();
                        email.EmailUC3();
                        break;
                }

            }
        }
    }
}