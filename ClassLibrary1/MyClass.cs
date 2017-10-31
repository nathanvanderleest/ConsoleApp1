using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class MyClass: Object // derives from System.Object by default
    {
        public override string ToString()
        {
            return base.ToString();
        }
    }

    class Class1 // derives from System.Object by default
    {

    }

}
