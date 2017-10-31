using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    // An abstract class cannot be instantiated and function cannot have an implementation
    // functions must be overridden in any non-abstract derived classes
    public abstract class AbstractClass
    {
        // By default abstract functions are virtual
        // If a class has an abstract function, then that class must also be abstract
        public abstract decimal CalculateHeatingCost();

        public abstract decimal Temperature { get; set; }

    }

    public class DerivedAbstractClass : AbstractClass
    {
        public override decimal Temperature { get { return this.temperature; } set { this.temperature = value; } }
        private decimal temperature;
        public override decimal CalculateHeatingCost()
        {
            //throw new NotImplementedException();
            return 5.0M / 2.0M;
        }
    }

    public abstract class GenericCustomer
    {
        private string name;
        public GenericCustomer()
            : base() // We could omit this line without affecting the compiled code.
        {
            this.name = "<no name>";
        }

        public GenericCustomer(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }

        }
    }

        public class Nevermore60Customer : GenericCustomer
        {
            private uint highCostMinutesUsed;
            
            public Nevermore60Customer(string name)
                : base(name)
            {
            }

        }

    
}