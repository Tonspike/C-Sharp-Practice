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

        public static Hashtable CreateHT()
        {
            Hashtable ht = new Hashtable();
            ht.Add("1", "jenna");
            ht.Add("2", "mike");
            if (ht.ContainsValue("sarah"))
            {
                Console.WriteLine("already there");
            }
            else
            {
                ht.Add("3", "sarah");
            }
            ICollection key = ht.Keys;
            foreach (string k in key)
            {
                Console.WriteLine(k + " : " + ht[k]);
            }

            return ht;
        }
        //problem: is string (char[]) a palindrome? recursive
        public static Boolean isPalindrome(char[] arr, int firstIndex, int lastIndex)
        {
            if (arr[firstIndex] == arr[lastIndex])
            {
                if (firstIndex < lastIndex)
                {
                    return isPalindrome(arr, firstIndex + 1, lastIndex - 1);
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        //problem: is string (char[] a palindrome? iterative
        public static Boolean isPalindrome2(char[] arr)
        {
            int lastCharIndex = arr.Length - 1;
            for (int i=0; i<arr.Length/2; i++)
            {
                if (arr[i] == arr[lastCharIndex])
                {
                    //keep going! decrement lastChar
                    lastCharIndex--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        //problem: find Longest Common Subsequence of two strings
        public static int LCS(String A, String B, int indexA, int indexB)
        {
            int LCSCount = 0;
            if (indexA == A.Length)
            {
                //End of string A, no subsequence
                return 0;
            }
            if (indexB == B.Length)
            {   //End of string B, no subsequence
                return 0;
            }
            //loop through string A and look for matches with string b
            for (int i = indexA; i < A.Length; i++)
            {
                //B.indexOf(valueBeingSearchedFor, StartingFromThisIndex, returns -1 if not found
                int inCommon = B.IndexOf(A[i], indexB);
                if (inCommon != -1)
                {
                    //if something is found, call recursively from the next index after the one in common.
                    int temp = 1 + LCS(A, B, i + 1, inCommon + 1);
                    if (LCSCount < temp)
                    {
                        LCSCount = temp;
                    }
                }
            }
            return LCSCount;
        }

        //problem: use a stack to evaluate a mathematical expression using only + and *, for example 1+2*8+8. Multiplication happens first, then addition.
        public static int Math()
        {
            char[] equation = { '1', '+', '2', '*', '8', '+', '8' };
            Console.Write("equation is: ");
            for (int j=0; j<equation.Length; j++)
            {
                Console.Write(equation[j]);
            }
            Console.WriteLine();

            Stack stack = new Stack();

            int count = 0;
            int i = 0;
            while (i < equation.Length) { 
                if (equation[i] != '+' && equation[i] != '*')
                {
                    var convertedI = char.GetNumericValue(equation[i]);
                    stack.Push(convertedI);
                    i++;
                    count++;
                }
                else if (equation[i] == '*')
                {
                    var temp = stack.Pop();
                    var convertedTemp = Convert.ToDouble(temp);
                    i++;
                    var convertedTemp2 = char.GetNumericValue(equation[i]);
                    convertedTemp *= convertedTemp2;
                    stack.Push(convertedTemp);
                    i++;
                }
                else
                {
                    i++;
                }
            }
            var answer = 0;
            for (int j = 0; j < count; j++)
            {
                var temp = stack.Pop();
                int convertedTemp = Convert.ToInt32(temp);
                answer += convertedTemp;
            }
            Console.WriteLine("answer is " + answer);
        return answer;
        }
        
        //problem: find the middle node data of a linkedlist
        public static void findMiddleNodeLL(Node head)
        {
            Node fastPointer = head;
            Node slowPointer = head;
            while (fastPointer.next != null && fastPointer.next.next != null)
            {
                slowPointer = slowPointer.next;
                fastPointer = fastPointer.next.next;
            }
            Console.WriteLine("finished, midpoint data: " + slowPointer.data);
        }
        //problem: determine if a linked list is circular
        public static Boolean isLLCircular(Node head)
        {
            Node fastP = head;
            Node slowP = head;
            while (fastP.next != null && fastP.next.next != null)
            {
                slowP = slowP.next;
                fastP = fastP.next.next;
                if (slowP == fastP)
                {
                    Console.WriteLine("true, LL is circular");
                    return true;
                }
            }
            Console.WriteLine("false, LL is not circular");
            return false;
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
        
        //Different version of Quicksort, closer to algorithm models I found
        public static void QuicksortA(int[] arr, int lowIndex, int highIndex)
        {
            //if high and low indices haven't met yet, keep going
            if (lowIndex < highIndex)
            {
                // partition, then run quicksort on both halves of partition
                int pivotIndex = PartitionA(arr, lowIndex, highIndex);
                QuicksortA(arr, lowIndex, pivotIndex - 1);
                QuicksortA(arr, pivotIndex + 1, highIndex);
            }
            //else: all is sorted. Done!
        }
        //partitioning for QuicksortA above
        public static int PartitionA(int[] arr, int lowIndex, int highIndex)
        {
            //set pivot as the value of the high index of the array, set left wall as the low index. Pivot can be anywhere, but high works for now.
            int pivotValue = arr[highIndex];
            int leftWallIndex = lowIndex;
            //loop: all values between the low index and just before the high index/pivot
            for (int i = lowIndex; i < highIndex; i++)
            {
                //if the value of arr[i] is less than the pivot value, swap arr[i] with arr[leftwallindex] (the low value), then increment leftwall index.
                //that means that everything less than the pivot value (BUT NOT MORE THAN) will be in the spots starting at the leftwall index and following.
                if (arr[i] <= pivotValue)
                {
                    swap(arr, leftWallIndex, i);
                    leftWallIndex++;
                }
            }
            //swap the highindex (the pivot value) with the leftwallindex (everything to the left of this is lower than the pivotvalue).
            swap(arr, leftWallIndex, highIndex);
            //return the leftwallindex as the new partition value; it is in the correct place now! Everything to the right and left of it need to be sorted.
            return leftWallIndex;
        }

        public static void swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
        
        //problem: given a string (char array), replace spaces with %20, in place. There are enough spaces given at the end of the existing string.
        public static char[] replaceSpaces()
        {
            char[] arr = CreateCharArray();
            int finalCharIndex = -1;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] != ' ')
                {
                    finalCharIndex = i;
                    break;
                }
            }

            int lastOpenIndex = arr.Length - 1;
            for (int i = finalCharIndex; i >= 0; i--)
            {
                if (arr[finalCharIndex] == ' ')
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

        //recursion practice!
        //problem: use recursion to make a function that takes two numbers as parameters (the base and the exponent) and outputs the first number raised to the power of the second number
        public static int Power(int number, int exponent)
        {
            //base case 1: if number is less than zero, return -1
            if (exponent < 0)
            {
                return -1;
            }
            //base case 2: if number is raised to the 0 power, output is 1
            if (exponent == 0)
            {
                return 1;
            }
            else
            {
                return number * Power(number, exponent - 1);
            }
        }
        //iterative solution to the same problem:
        public static int IterativePower(int number, int exponent)
        {
            int answer = 1;
            if (exponent < 0)
            {
                return -1;
            }
            if (exponent == 0)
            {
                return 1;
            }
            for (int i = 1; i <= exponent; i++)
            {
                answer *= number;
            }
            return answer;
        }

        //recursion practice: use recursion to create a function that takes a number as a parameter, and returns the factorial (!) of that number.
        public static int RecursiveFactorial(int number)
        {
            //base case:
           if (number < 2)
            {
                return 1;
            }
           else
            {
                return (number * RecursiveFactorial(number - 1));
            }
        }
        //iterative version of the factorial function above:
        public static int IterativeFactorial(int number)
        {
            if (number < 2)
            {
                return 1;
            }
            else
            {
                int answer = number;
                for (int i = number-1; i >= 2; i--)
                {
                    answer *= i;
                }
                return answer;
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
