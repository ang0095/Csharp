using System;
using System.Collections.Generic;

namespace mnew
{
  class Node
    {
        public int data;
        public Node next;
    }
  class Program
  {
     public class LinkedStack
        {
            public Node top;
            public void LinkedListTraversal()
            {
                Node ptr = top;
                while (ptr != null)
                {
                    Console.WriteLine($"Element: {ptr.data}");
                    ptr = ptr.next;
                }
            }
            public bool IsEmpty()
            {
                return top == null;
            }

            public void Push(int newData)
            {
                
                Node insert = new Node();
                insert.data = newData;
                insert.next = top;
                top = insert;


            }

            public int Pop()
            {
                if (IsEmpty())
                {
                    Console.WriteLine("Stack Underflow");
                    return -1; // Return a default value or throw an exception as needed
                }
                else
                {
                    int x = top.data;
                    top = top.next;
                   // top.next = null;  -----> putting this in the code is not correct 

                    return x;
                }
            }

            public int Peek()
            {
                if (IsEmpty())
                {
                    Console.WriteLine("Stack Empty");
                    return -1; // Return a default value or throw an exception as needed
                }
                else 
                { return top.data; }
            }
        }
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
            int itemPeeked = stack.Peek();
            Console.WriteLine($"Peeked element: {itemPeeked}");
    }    
  }
}
