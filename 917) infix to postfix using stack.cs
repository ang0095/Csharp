using System;
using System.Collections.Generic;
using System.ComponentModel;


namespace nmew
{
   class Program
    {
        public static bool isOperator(char a)
        {
            return (a == '+') || (a == '-') || (a == '*') || (a == '/');
        }
        public  static int precedence(char ch)
        {
            if (ch == '*' || ch == '/')
            {
                return 2;
            }
            else if (ch == '+' || ch == '-')
            {
                return 1;
            }
            else return 0;
        }
        public static void Main(string[] args)
        {
            string infix = "a-b";
            int i = 0;  // track infix traversal 
            int j = 0;  // track postfix traversal
            char[] postfix = new char[infix.Length];
            Stack<char> stack = new Stack<char>();

            while(i < infix.Length) 
            {
                if (!isOperator(infix[i]))
                {
                    postfix[j] = infix[i];
                    j++;      // values postfix me add karne ke bad j ko badhana hogaa
                    i++;      // infix ki value postfix me dalne ke liyye i ko bhi badhana hogaa
                }
                else
                {                   
                    if (stack.Count == 0 || precedence(infix[i]) > precedence(stack.Peek())) // stack.Count == 0 is necessary kyuki initially stack empty hai
                    {
                        stack.Push(infix[i]);
                        i++;
                    }
                    else
                    {
                        postfix[j] = stack.Pop(); // this is the case where stack me jo element add jaa raha hai usko precedence stack.Peek se kam hai
                        j++;
                    }
                }               
            }
            if (i == infix.Length)     //This is to make sure i reaches the end of infix string
            {
                while (stack.Count != 0)       // after all letters, numbers are added to postfix, we empty stack to add the remaing operaters
                {
                    postfix[j] = stack.Pop();
                    j++;
                }
            }
            foreach (char ch in postfix)
            {
                if (ch != '\0') // Skip null characters in the output array
                {
                    Console.Write(ch);
                }
            }
        }
    }
}
