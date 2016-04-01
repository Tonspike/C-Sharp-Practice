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

            Emailer.SendMail(subject, body, email);
        }

        
    }
}
