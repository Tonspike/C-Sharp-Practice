using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Practice
{
    class Factory
    {
        public static Queue<int> QueuePractice()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(100);
            queue.Enqueue(1000);
            queue.Enqueue(129);
            return queue;
        }

        public static Stack<int> StackPractice()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            return stack;
        }   

        public static LinkedList CreateLinkedList()
        {
            LinkedList myList = new LinkedList();
            myList.AddLast("Head of list");
            myList.AddLast("Hello");
            myList.AddLast("Magical");
            myList.AddLast("World");
            myList.AddLast("Tail of list");
            myList.printAllNodes();
            return myList;
        }
        //problem: given a linked list, reverse the linked list iteratively
        public static LinkedList ReverseLLIteratively(LinkedList LinkedList)
        {
            Node headValue = LinkedList.head, previousPointerValue = null;
            while (headValue != null)
            {
                Node current = headValue.next;
                headValue.next = previousPointerValue;
                previousPointerValue = headValue;
                headValue = current;
            }
            LinkedList.head = previousPointerValue;
            return LinkedList;
        }

        //problem: given a linked list, reverse the linked list recursively
        public static LinkedList ReverseLLRecursively (LinkedList linkedlist, Node node)
        {
            if (node == null || node.next == null) //if head is null or we are at the tail
            {
                linkedlist.head = node; //we are at the tail or empty list, set the new head to the tail
                return linkedlist;
            }

            ReverseLLRecursively(linkedlist, node.next);

            var nextItem = node.next; //get the next item out, dealing with references don't want to override it
            node.next = null;         //once you get the next item out, you can delete the *reference* i.e. link to it
            nextItem.next = node;     //set the item you got out link to next item to the current item i.e. reverse it
            return linkedlist;
        }

        //problem: given a stack of unknown size, reverse that stack using only one other stack and a variable.
        public static void Reverse()
        {
            var stack1 = StackPractice();
            int temp = 0;
            Console.WriteLine("first stack:");
            foreach (int i in stack1)
            {
                Console.WriteLine(i);
            }

            Stack<int> stack2 = new Stack<int>();
            int count = 0;
            foreach (int i in stack1)
            {
                //get an accurate count of how many elements have to be moved
                count++;
            }
            int totalcount = count;
            //start process
            for (int k = 0; k < totalcount + 2; k++)
            {
                //get temp variable first
                temp = stack1.Pop();//save the top item in the variable, then push the rest through.
                for (int i = 1; i < totalcount; i++)
                {
                    stack2.Push(stack1.Pop());
                }

                stack1.Push(temp); //temp number is now at the bottom of stack, push the rest in after it:

                for (int i = 1; i < totalcount; i++)
                {
                    stack1.Push(stack2.Pop()); //empty first stack, ready for new input
                }

                totalcount--;

                //end process
                Console.WriteLine("second stack1:");
                foreach (int i in stack1)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void SayHello()
        {
            Console.WriteLine("Hello!");

            var subject = "test";
            var body = "This is another test";
            var email = "test2@test.com";

            DerivedEmailer.SayHello(subject, body, email);
        }
        public static void ConditionalMail(int one, int two)
        {
            var subject = "test";
            var body = "This is another test";
            var email = "kristenlackritz@gmail.com";

            if (one < two)
            {
                body = one + " is less than " + two;
            }
            if (one > two)
            {
                body = one + " is more than " + two;
            }
            if (one == two)
            {
                body = one + " is equal to" + two;
            }
            DerivedEmailer.SayHello(subject, body, email);
        }
        
    }
}
