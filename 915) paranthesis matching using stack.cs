using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace mnew
{
    
    class Program
    {
        
        public static void Main(string[] args)
        {

            string sentence = "((3+2)=5)()";
            int x = sentence.Length;
            Console.WriteLine(x);
            char[] data = new char[x];
            for (int i = 0; i < x; i++)
            {
                data[i] = sentence[i];
            }
            foreach (char element in data)
            {
                Console.WriteLine(element);
            }
            Stack<char> stack = new Stack<char>();
            for(int i = 0; i < x; i++)
            {
                if (data[i] == '(') 
                {
                    stack.Push('(');
                }
                if (data[i] == ')')
                {
                    if (stack.Count == 0)
                    {
                        Console.WriteLine("sequence error"); // There's a closing parenthesis without a matching opening parenthesis
                    }

                    stack.Pop();
                }
            }
            if(stack.Count > 0)
            {
                Console.WriteLine("Unbalanced expression, extra closing brackets needed");
            }
            else if(stack.Count == 0) 
            {
                Console.WriteLine("Balanced expression");
            }
            else // This program will throw an exception if closing brackets are more than opening bracket or in case of sequence error, we can use exception handling for this(try catch throw).
            {
                Console.WriteLine("Unbalanced equation, opening bracket(s) missing");
            }
        }
    }
}
