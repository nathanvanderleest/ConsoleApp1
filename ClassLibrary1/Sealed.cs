using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    // sealed means that you cannot derived from this class
    public sealed class FinalClass: MyBaseClass
    {
        // In order to use the sealed keyword on a method or property,
        // it must have first been overridden from a base class
        public sealed override string VirtualMethod()
        {
            return "This VirtualMethod() is overridden from MyBaseClass and is sealed.";
        }
    }
}
