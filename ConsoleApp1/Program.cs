using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericsLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list1;
            list1 = new LinkedList<int>();
            list1.AddLast(2);
            list1.AddLast(4);
            list1.AddLast(6);
            list1.AddLast(8);
            
            Console.WriteLine(list1.First.Value);
            Console.WriteLine(list1.Last.Value);


            int[] u = { };

            Console.WriteLine("-----------------------------------------");
            foreach (int i in list1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("DocumentManager");

            var dm = new DocumentManager<Document>();
            dm.AddDocument(new Document("Title A", "Sample A"));
            dm.AddDocument(new Document("Title B", "Sample B"));

            Console.WriteLine("DisplayAllDocuments: ");
            dm.DisplayAllDocuments();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();

            if (dm.IsDocumentAvailable)
            {
                Document d = dm.GetDocument();
                Console.WriteLine(d.Content);
            }
            else
            {
                Console.WriteLine("No documents on the queue");
            }

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();
            Console.WriteLine("DisplayAllDocuments: ");
            dm.DisplayAllDocuments();
            Console.WriteLine("-----------------------------------------");

            IntCalc intCalc = new IntCalc();
            Console.WriteLine("Add 4 and 5 = " + intCalc.Add(4, 5));
            Console.WriteLine("Sub 4 and 5 = " + intCalc.Sub(4, 5));
            Console.WriteLine();

            Console.WriteLine("-----------------------------------------");




            Console.WriteLine();



            Console.WriteLine();
            Console.ReadKey();
        }

    }
}
