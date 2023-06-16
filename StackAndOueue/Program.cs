using StackAndOueue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    internal class program
    {
        static void Main(string[] args)
        {
            StackDS stack = new StackDS();
             stack.Push(70);
             stack.Push(30);
             stack.Push(56);
             stack.Display();
        }
    }
}