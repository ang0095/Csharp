using System;
using System.Collections.Generic;

namespace mnew
{
  class Program
  {
    public static void Main(string[] args) 
    {
     LinkedStack stack = new LinkedStack();
            stack.Push(78);
            stack.Push(5);
            stack.Push(8);

            stack.LinkedListTraversal();
            int itemPoped = stack.Pop();
            Console.WriteLine($"Poped element: {itemPoped}");
            stack.LinkedListTraversal();
            Console.WriteLine("\n");
            int itempeeked = stack.Peek();
            Console.WriteLine(itempeeked );
    }    
  }
}
