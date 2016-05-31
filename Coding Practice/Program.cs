using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //begin main program 
            int[] intArray = Factory.CreateIntArray();
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write(intArray[i] + " ");
            }
            /*char[] array = Factory.CreateCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }*/
            Console.WriteLine();

          /*  LinkedList linkedlist = Factory.CreateLinkedList();
            Console.WriteLine("Original Linked List: ");
            Console.WriteLine();
            Console.WriteLine("Reversed List: ");
            //LinkedList linkedlist2 = Factory.ReverseLLIteratively(linkedlist);
            //linkedlist2.printAllNodes();
            LinkedList linkedlist3 = Factory.ReverseLLRecursively(linkedlist, linkedlist.head);
            linkedlist3.printAllNodes();*/

            //end main program
        }
    }
}
