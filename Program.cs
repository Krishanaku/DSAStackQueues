using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAStackQueues
{
    public class Program
    { 
        public static void Main(string[] args) 
        {
            LinkedList list = new LinkedList();
            Stack stack = new Stack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);

            foreach (int i in stack)
            {
                list.Add(i);
            }
            Console.WriteLine("\nTop of stack : {0}", stack.Peek());


        }
    }
}
