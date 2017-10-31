using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    // You cannot supply implementations of any members of an interface, so no fields
    // Only declarations of methods, properties, indexers, and events
    // You cannot Instantiate an interface, so no constructors
    public interface IBankAccount
    {
        // Interface members are always implicitly public
        // It's up to the implementing classes to decide the modifiers
        void PayIn(decimal amount);
        bool Withdraw(decimal amount);
        decimal Balance { get; }
    }

    public interface ITransferBankAccount: IBankAccount
    {
        bool TransferTo(IBankAccount destination, decimal amount);
    }

    namespace VenusBank
    {
        public class SaverAccount: IBankAccount
        {
            private decimal balance;
            public void PayIn(decimal amount)
            {
                this.balance += amount;
            }
            public bool Withdraw(decimal amount)
            {
                if(this.balance >= amount)
                {
                    this.balance -= amount;
                    return true;
                }
                Console.WriteLine("Withdrawal attempt failed.");
                return false;
            }
            public decimal Balance { get { return this.balance; } }
            public override string ToString()
            {
                return String.Format("Venus Bank Saver: Balance = {0,6:C}", this.balance);
            }
        }
    }

    namespace JupiterBank
    {
        public class GoldAccount : IBankAccount
        {
            private decimal balance;
            public void PayIn(decimal amount)
            {
                this.balance += amount;
            }
            public bool Withdraw(decimal amount)
            {
                if (this.balance >= amount)
                {
                    this.balance -= amount;
                    return true;
                }
                Console.WriteLine("Withdrawal attempt failed.");
                return false;
            }
            public decimal Balance { get { return this.balance; } }
            public override string ToString()
            {
                return String.Format("Jupiter Bank Gold: Balance = {0,6:C}", this.balance);
            }
        }

        public class CurrentAccount : ITransferBankAccount
        {
            private decimal balance;
            public void PayIn(decimal amount)
            {
                this.balance += amount;
            }
            public bool Withdraw(decimal amount)
            {
                if (this.balance >= amount)
                {
                    this.balance -= amount;
                    return true;
                }
                Console.WriteLine("Withdrawal attempt failed.");
                return false;
            }
            public decimal Balance { get { return this.balance; } }
            public override string ToString()
            {
                return String.Format("Mars Bank Current: Balance = {0,6:C}", this.balance);
            }
            public bool TransferTo(IBankAccount destination, decimal amount)
            {
                if(this.balance >= amount)
                {
                    this.Withdraw(amount);
                    destination.PayIn(amount);
                    return true;
                }
                Console.WriteLine("Withdrawal attempt failed.");
                return false;
            }
        }
    }
}
