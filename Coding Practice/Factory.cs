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

        public static char[] CreateCharArray()
        {
            char[] myArray = {'h', 'e', 'l', 'l', 'o' , ' ', 'w', 'o', 'r', 'l', 'd', ' ', ' '};
            return myArray;
        }

        public static int[] CreateIntArray()
        {
            int[] myArray = { 1, 6, -1, 0, 10, 4 };
            return myArray;
        }
        //problem: figure out quicksort
        //first half: partitioning. Make the pivot value equal to the left index value. 
        //While leftindex VALUE is smaller than the pivot, increment up. 
        //while rightindex VALUE is greater than the pivot, increment down.
        //if left index is less than right index (because the two indices haven't incremented to where they're met), swap the values.
        //Else return the right value
        public static int Partition(int[] arr, int LIndex, int RIndex)
        {
            int pivot = arr[LIndex];
            while (true)
            {
                while (arr[LIndex] < pivot)
                {
                    LIndex++;
                }
                while (arr[RIndex] > pivot)
                {
                    RIndex--;
                }
                if (LIndex < RIndex)
                {
                    //swap!
                    int temp = arr[RIndex];
                    arr[RIndex] = arr[LIndex];
                    arr[LIndex] = temp;
                }
                else {
                    return RIndex;
                }
            }
        }
        //quicksort part 2, the recursive part
        //if the left and right indices haven't met, get the pivot from the partition code (above)
        //if pivot index is greater than 1, decrement and pass in to recursive call as right index.
        //if pivot index +1 is less than the right index, increment and pass in to recursive call as left index
        public static void RecursiveQuicksort(int[] arr, int LIndex, int RIndex)
        {
            if (LIndex < RIndex)
            {
                int pivotIndex = Partition(arr, LIndex, RIndex);
                if (pivotIndex > 1)
                {
                    RecursiveQuicksort(arr, LIndex, RIndex - 1);
                }
                if (pivotIndex + 1 < RIndex)
                {
                    RecursiveQuicksort(arr, LIndex + 1, RIndex);
                }
            }

            //(else) base case: do nothing, all sorted!
        }

        //problem: given a string (char array), replace spaces with %20, in place. There are enough spaces given at the end of the existing string.
        public static char[] replaceSpaces()
        {
            char[] arr = CreateCharArray();
            int finalCharIndex = -1;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (!Char.IsWhiteSpace(arr[i]))
                {
                    finalCharIndex = i;
                    break;
                }
            }

            int lastOpenIndex = arr.Length - 1;
            for (int i = finalCharIndex; i >= 0; i--)
            {
                if (Char.IsWhiteSpace(arr[finalCharIndex]))
                {
                    arr[lastOpenIndex] = '0';
                    arr[lastOpenIndex - 1] = '2';
                    arr[lastOpenIndex - 2] = '%';
                    finalCharIndex--;
                    lastOpenIndex = lastOpenIndex - 3;                    
                }
                else {
                    arr[lastOpenIndex] = arr[finalCharIndex];
                    finalCharIndex--;
                    lastOpenIndex--;
                }
            }
            return arr;
        }

        //problem: given an array of unsorted integers, find the index (if one exists) that is equal to the sum of the rest of the numbers in the array
        public static int splitArray()
        {
            int[] arr = CreateIntArray();
            int target = 0;
            int answer = -1;
            //target number is the sum of all the numbers in the array, divided by two
            for (int i = 0; i < arr.Length; i++)
            {
                target += arr[i];
            }
            target /= 2;
            //search for target, if found, save index
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    answer = i;
                }
            }
            //if answer is -1, no index was found. Otherwise, this is the index with the correct number.
            return answer;
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
