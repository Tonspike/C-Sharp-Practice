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
