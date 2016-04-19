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
            var stack = Factory.StackPractice();
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
            var queue = Factory.QueuePractice();
            foreach (int i in queue)
            {
                Console.WriteLine(i);
            }
            var qnum = queue.Dequeue();
            var snum = stack.Pop();

            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
            foreach (int i in queue)
            {
                Console.WriteLine(i);
            }
        }
    }
}
