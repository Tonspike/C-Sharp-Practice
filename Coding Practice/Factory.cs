using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Practice
{
    class Factory
    {
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
