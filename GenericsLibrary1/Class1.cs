using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsLibrary1
{
    class Class1
    {
        // Generics:
        // Performance
        // Generics elimnates boxing and unboxing.
        // Boxing: When a value type is converted into a reference type
        // Unboxing: When a reference type is converted into a values type (ex. Casting: int num = (int) Object1.Number();)

        // Type Safety
        // Generic classes forces Type Safety by allowing only one type: List<int>

        // Binary code reuse
        // A Generic class only needs to be defined once, and then it can be instantiated with different value types
        // ex. var listInt = new List<int>(); and var listString = new List<string>();

        // Code Bloat
        // .NET does not duplicate the Generic class in the IL (assembly). For Generic classes, when the JIT complier (in the CLR),
        // converts the IL into native code, a new class for every value type obect is created (ex. List<int> and List<string>).
        // A new class is not created in the native code for every reference type (ex. List<MyClass> and List<MyDifferentClass>).
        // Naming Guidelines
        // 

        // More Info
            // null can only be assigned to reference types. Since a generic type can be either reference type or value type, 
            // you cannot assign null to a generic type

    }
}
