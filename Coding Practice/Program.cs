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
            //for (int j = 0; j< count; j++)//repeat this process as many times as count.
            //{
                int temp = stack1.Pop();//save the top item in the variable, then push the rest through.
                foreach (int i in stack1)
                {
                    stack2.Push(i);
                }
                for (int i = 1; i < count; i++)
                {
                    stack1.Pop(); //empty first stack, ready for new input
                }
                stack1.Push(temp); //temp number is now at the bottom of stack, push the rest in after it:
                foreach (int i in stack2)
                {
                    stack1.Push(i);
                }
            for (int i = 1; i < count; i++)
            {
                stack2.Pop(); //empty first stack, ready for new input
            }
            //  }
            Console.WriteLine("second stack:");
            foreach (int i in stack1)
            {
                Console.WriteLine(i);
            }
           
            


        }
    }
}
