using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using ClassLibrary1.VenusBank;
using ClassLibrary1.JupiterBank;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            Console.WriteLine("MyClass myClass = new MyClass()...");
            Console.WriteLine(myClass.ToString());
            Console.WriteLine();

            MyBaseClass myBaseClass = new MyBaseClass();
            myBaseClass.ForeName = "Base Class: ForeName";
            Console.WriteLine(myBaseClass.VirtualMethod());
            Console.WriteLine(myBaseClass.ForeName);
            Console.WriteLine();

            MyDerivedClass myDerivedClass = new MyDerivedClass();
            myDerivedClass.ForeName = "Derived Class: ForeName";
            Console.WriteLine(myDerivedClass.VirtualMethod());
            Console.WriteLine(myDerivedClass.ForeName);
            Console.WriteLine();

            MyBaseClass num = new MyDerivedClass();
            Console.WriteLine("MyBaseClass num = new MyDerivedClass()...");
            Console.WriteLine(num.VirtualMethod());
            Console.WriteLine();

            DerivedAbstractClass derivedAbstractClass = new DerivedAbstractClass();
            derivedAbstractClass.Temperature = 5.0M;
            Console.WriteLine("derivedAbstractClass.CalculateHeatingCost() = " + derivedAbstractClass.CalculateHeatingCost());
            Console.WriteLine();

            FinalClass finalClass = new FinalClass();
            Console.WriteLine("FinalClass finalClass = new FinalClass()...");
            Console.WriteLine("finalClass.VirtualMethod() = " + finalClass.VirtualMethod());
            Console.WriteLine();

            GenericCustomer generic = new Nevermore60Customer("Nate");
            Console.WriteLine("GenericCustomer generic = new Nevermore60Customer(\"Nate\")");
            Console.WriteLine("generic.Name = " + generic.Name);
            Console.WriteLine();

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("IBankAccount Interface example...");

            IBankAccount venusAccount = new SaverAccount();
            IBankAccount jupiterAccount = new GoldAccount();
            venusAccount.PayIn(200);
            venusAccount.Withdraw(100);
            Console.WriteLine(venusAccount.ToString());
            jupiterAccount.PayIn(500);
            jupiterAccount.Withdraw(600);
            jupiterAccount.Withdraw(100);
            Console.WriteLine(jupiterAccount.ToString());
            Console.WriteLine();

            Console.WriteLine("ITransferBankAccount Interface example...");
            ITransferBankAccount marsAccount = new CurrentAccount();
            marsAccount.PayIn(600);
            Console.WriteLine(marsAccount.ToString());
            Console.WriteLine("Transfer 200 from Mars to Venus");
            marsAccount.TransferTo(venusAccount, 200);
            Console.WriteLine(marsAccount.ToString());
            Console.WriteLine(venusAccount.ToString());
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
