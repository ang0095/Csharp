// This is a provided code. Check code & provide a reviewed code
using System;
using System.Collections.Generic;

namespace BalancedParentheses
{
    class Program
    {
        public static void Main(string[] args)
        {
            string sentence = "((3+2)=5)[]{()}";
            bool isBalanced = CheckBalancedParentheses(sentence);

            if (isBalanced)
            {
                Console.WriteLine("Balanced expression");
            }
            else
            {
                Console.WriteLine("Unbalanced expression");
            }
        }

        public static bool CheckBalancedParentheses(string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char character in input)
            {
                if (IsOpeningParenthesis(character))
                {
                    stack.Push(character);
                }
                else if (IsClosingParenthesis(character))
                {
                    if (stack.Count == 0 || !AreMatchingParentheses(stack.Pop(), character))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }

        public static bool IsOpeningParenthesis(char c)
        {
            return c == '(' || c == '[' || c == '{';
        }

        public static bool IsClosingParenthesis(char c)
        {
            return c == ')' || c == ']' || c == '}';
        }

        public static bool AreMatchingParentheses(char opening, char closing)
        {
            return (opening == '(' && closing == ')') ||
                   (opening == '[' && closing == ']') ||
                   (opening == '{' && closing == '}');
        }
    }
}
