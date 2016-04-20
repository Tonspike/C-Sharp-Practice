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
            //problem: given a stack of unknown size, reverse that stack using only one other stack and a variable.
            var stack1 = Factory.StackPractice();
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
    }
}
