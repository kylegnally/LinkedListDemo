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
        }
    }
}
