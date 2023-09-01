using System;
using System.Collections.Generic;


namespace nmew
{

   
    class Program
    {

      

        public static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);  
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);


            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n");
            int itempoped1 = stack.Pop();
            int itempoped2 = stack.Pop();

            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n");
            Console.WriteLine($"item poped = {itempoped1}");
            Console.WriteLine($"item poped = {itempoped2}");
            Console.WriteLine("\n");

            int itempeeked = stack.Peek();
            Console.WriteLine($"item peeked = {itempeeked}");
            
        }

    }
}
