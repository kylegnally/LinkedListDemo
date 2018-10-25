using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_inclass4
{
    class GenericLinkedList<T> : IGenericLinkedList<T>
    {
        // Make node class
        protected class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
        }

        //*************************
        // Variables
        //*************************
        // Head and Tail pointer to the start and end of the list.
        protected Node head;
        protected Node tail;
        // For the size of the list
        protected int size = 0;

        //*************************
        // Properties
        //*************************
        public bool IsEmpty
        {
            get
            {
                // To check whether or not it is empty we can check
                // to see if the head pointer is null. If so, there
                // are no nodes in the list, so it must be empty.
                return head == null;
            }
        }

        public int Size
        {
            get
            {
                return size;
            }
        }


        //*************************
        // Methods
        //*************************
        public void AddToFront(T Data)
        {
            // Make a new variable to also reference the head of the list
            Node oldHead = head;
            // Make a new node and assign it to the head variable
            head = new Node();
            // Set the data on the new node
            head.Data = Data;
            // Make the next property of the new node point to the old head
            head.Next = oldHead;
            // Increment the size of the list
            size++;
            // Ensure that if we are adding the very first node to the list
            // that the tail will be pointing to the new node we create
            if (size == 1)
            {
                tail = head;
            }
        }

        public void AddToBack(T Data)
        {
            // Make a pointer to the tail called old tail
            Node oldTail = tail;
            // Make a new node and assign it to the tail variable
            tail = new Node();
            // Assign the data and set the next pointer
            tail.Data = Data;
            tail.Next = null;

            // Check to see if the list is empty. If so, make the head
            // point to the same location as the tail.
            if (IsEmpty)
            {
                head = tail;
            }
            else
            {
                // We need to take the oldTail and make it's Next property
                // point to the tail that we just created
                oldTail.Next = tail;
            }

            // Increase size
            size++;
        }

        public T RemoveFromFront()
        {
            // If it is empty throw an error
            if (IsEmpty)
            {
                throw new Exception("List is empty");
            }

            // Let's get the data to return
            T returnData = head.Data;

            // Move the head pointer to the next in the list
            head = head.Next;

            // Decrease the size
            size--;

            // Check to see if we just removed the last node from the list
            if (IsEmpty)
            {
                tail = null;
            }

            // Return the returnData we pulled out from the first node
            return returnData;
        }

        public T RemoveFromBack()
        {
            // Check for empty, throw exception if it is
            if (IsEmpty)
            {
                throw new Exception("List is empty");
            }

            // Get the return data right off the bat
            T returnData = tail.Data;

            // Check to see if we are on the last node
            // If so, we can just set the head and tail to null since
            // we want to remove the only node remaining in the list.
            if (head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                // Else, we need to traverse the list and stop right before
                // we reach the tail

                // Create a temporary node to 'walk' down the list
                Node current = head;

                // Keep moving forward until the current.Next is
                // equal to the tail.
                // Keep looking while current.Next != tail
                while (current.Next != tail)
                {
                    // Set the current pointer to the current pointer's next node
                    current = current.Next;
                }

                // We are now in poisition to do some work
                // Set the tail to the current position
                tail = current;
                // Make the last node that we are removing go away
                // by setting tail's next property to null
                tail.Next = null;
            }

            return returnData;
        }

        public void Display()
        {
            Console.WriteLine("The list is:");
            // Setup a current node to walk the list
            // start it at the head node
            Node current = head;
            // Loop through the nodes until we hit null
            // which will signify the end of the list
            while (current != null)
            {
                // Write out current's data
                Console.WriteLine(current.Data);
                // Move to the next node
                current = current.Next;
            }

            Console.WriteLine();
        }
    }
}
