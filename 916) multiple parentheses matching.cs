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
            else
            {
                Console.WriteLine("Unbalanced equation, opening bracket(s) missing");
            }
        }
    }
}
