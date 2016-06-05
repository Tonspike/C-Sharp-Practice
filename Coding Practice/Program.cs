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
           /* List<int> mylist = new List<int>();
            mylist.Add(1);
            mylist.Add(2);
            mylist.Add(3);
            Console.WriteLine("List: ");
            foreach (int num in mylist)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.WriteLine("sets: ");
            var subsets = Factory.GetSubsetsOfASet(mylist, 0);
            foreach (var subset in subsets)
            {
                Console.Write("[");
                foreach (var item in subset)
                {
                    Console.Write(item + " ");
                }
                Console.Write("]");
            }*/
            /*
            char[] myArray = { 'e', 'v', 'e', 'n'};
            var answer = Factory.isPalindrome2(myArray);
            Console.WriteLine("answer is " + answer);*/

            //Factory.LCS("geek", "eke", 0, 0);

            //Factory.Math();
            //Factory.CreateHT();
            /*int num = Factory.IterativeFactorial(4);
             Console.WriteLine(num);*/

            /*int num = Factory.IterativePower(2, 3);
            Console.WriteLine(num);*/

            /*int[] myArray = Factory.CreateIntArray();
            Console.WriteLine("Original Array: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }
            Console.WriteLine();
            Factory.QuicksortA(myArray, 0, myArray.Length - 1);
            Console.WriteLine("Sorted Array: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }
            Console.WriteLine();*/

            /*
            char[] myString = Factory.replaceSpaces();
             for (int i = 0; i < myString.Length; i++)
             {
                 Console.Write(myString[i]);
             }*/

            /*int x = Factory.splitArray();
            Console.WriteLine("x: " + x);*/

            /*int[] intArray = Factory.CreateIntArray();
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write(intArray[i] + " ");
            }*/
            /*char[] array = Factory.CreateCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();*/

            Console.WriteLine("Original Linked List: ");
            LinkedList linkedlist = Factory.CreateLinkedList();
            Console.WriteLine();
            Factory.ReverseLLRecursively2(linkedlist);
            linkedlist.printAllNodes();
            /*
            Console.WriteLine("Reversed List: ");
            //LinkedList linkedlist2 = Factory.ReverseLLIteratively(linkedlist);
            //linkedlist2.printAllNodes();
            LinkedList linkedlist3 = Factory.ReverseLLRecursively(linkedlist, linkedlist.head);
            linkedlist3.printAllNodes();*/

            //end main program
        }
    }
}
