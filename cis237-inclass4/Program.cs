using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_inclass4
{
    class Program
    {
        static void Main(string[] args)
        {
            IIntegerLinkedList linkedList = new IntegerLinkedList();

            linkedList.AddToFront(5);
            linkedList.AddToFront(6);
            linkedList.AddToFront(3);

            linkedList.Display();

            linkedList.AddToBack(2);

            linkedList.Display();

            linkedList.RemoveFromFront();

            linkedList.Display();

            linkedList.RemoveFromBack();

            linkedList.Display();

            Console.WriteLine();
            Console.WriteLine("*********** Generic Below ***********");
            Console.WriteLine();

            // Do some generic linked list stuff
            // Create a generic linked list for strings
            IGenericLinkedList<string> genericLinkedList = new GenericLinkedList<string>();
            // Here is one for doubles. Not gonna use it though. Just to see that it can hold other types.
            IGenericLinkedList<double> genericDoubleLinkedList = new GenericLinkedList<double>();

            // Let's use the string one we created
            genericLinkedList.AddToFront("1");
            genericLinkedList.AddToFront("FoObAr");
            genericLinkedList.AddToFront("3");
            genericLinkedList.AddToBack("4");
            genericLinkedList.AddToBack("5");
            genericLinkedList.AddToBack("fizbuz");
            genericLinkedList.AddToBack("8");
            genericLinkedList.Display();
            genericLinkedList.RemoveFromFront();
            genericLinkedList.RemoveFromFront();
            genericLinkedList.RemoveFromBack();
            genericLinkedList.Display();
            
            // We can actually collect the value that is returned too, if needed.
            string returnedValue = genericLinkedList.RemoveFromFront();
            Console.WriteLine();
            Console.WriteLine("The returned value is: " + returnedValue);
        }
    }
}
