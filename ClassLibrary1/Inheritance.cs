using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class MyBaseClass
    {
        public virtual string VirtualMethod()
        {
            return "This method is virtual and defined in MyBaseClass";
        }

        public virtual string ForeName
        {
            get { return this.foreName; }
            set { this.foreName = value; }
        }
        private string foreName;
    }

    public class MyDerivedClass : MyBaseClass
    {
        public override string VirtualMethod()
        {
            return "This method is an override and defind in MyDerivedClass.";
        }
    }
}
