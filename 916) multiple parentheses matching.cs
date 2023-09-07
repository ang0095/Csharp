using System;
using System.Collections.Generic;

namespace nmew
{
    class Program
    {
        public static bool AreMatchingParentheses(char opening, char closing)
        {
            return (opening == '(' && closing == ')') ||
                   (opening == '[' && closing == ']') ||
                   (opening == '{' && closing == '}');
        }
        public static bool IsOpeningParenthesis(char c)
        {
            return c == '(' || c == '[' || c == '{';
        }

        public static bool IsClosingParenthesis(char c)
        {
            return c == ')' || c == ']' || c == '}';
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
                    // here stack.Count == 0 takes care of condition if there's a closing parenthesis first without a matching opening parenthesis
                    // whereas !AreMatchingParentheses(stack.Pop(), character) takes care of condition where the parentheses are not of the same type.
                    {
                        return false;
                    }                    
                }
            }

            return stack.Count == 0;
        }

        public static void Main(string[] args)
        {
            string sentence = "())(";
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
    }
}
