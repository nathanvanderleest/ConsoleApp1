using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MyClass
    {
        // If no constructor is declared, 
        // then the basic one below is defined by the compiler
        public MyClass()
        {

        }

        // If only this constructor is declared, 
        // then the complier will create the one above.
        public MyClass(int number)
        {
            this.Number = number;
        }

        private int _number;

        public int Number
        {
            get { return _number;  }
            set { _number = value;  }
        }

    }
}
