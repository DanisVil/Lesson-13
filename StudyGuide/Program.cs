#define DEBUG_ACCOUNT
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankDll;
using BuildingDll;

namespace StudyGuide
{
    class Program
    {
        static void Main(string[] args)
        {
            //t14.1
            RUBBankAccount test = new RUBBankAccount(0, BankAccount.Type.Current);
            test.DumpToScreen();

            //t14.2
            RationalNumber iiaaa = new RationalNumber(0, 1);
            Type t = typeof(RationalNumber);
            object[] attrs = t.GetCustomAttributes(false);
            foreach (DeveloperInfoAttribute attr in attrs)
            {
                Console.WriteLine(attr);
            }

            //ht14.1
            t = typeof(Building);
            attrs = t.GetCustomAttributes(false);
            foreach (BuildingDeveloperAttribute attr in attrs)
            {
                Console.WriteLine(attr);
            }
            Console.ReadKey();
        }
    }
}
