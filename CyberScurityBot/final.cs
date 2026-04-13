using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CyberScurityBot
{
    internal class final
    {
        // this is where we use delaye to make the program be like it is spaking to a real person use char to print a letter
        public void Display(String message)// remeber that message is all the promt we are display to the user
        {
            foreach (char c in message)
            {
                Console.WriteLine(c);
                Thread.Sleep(25); // int speeed = 50 how fast you what the letters to move
            }
            Console.WriteLine();
        }
 
    }
}
