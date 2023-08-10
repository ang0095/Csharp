using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace nmew
{
    

    class Program
    {

        static int LinearSearch(int[] arr, int size, int element)
        {
            for(int i = 0; i < size; i++)
            {
                if (arr[i] == element)
                {
                    return i;
                }
            }
                return -1;
        }
        public static void Main(string[] args)
        {
            int[] myArray = { 1, 25, 36, 45, 58, 3, 16, 56 };
            int size = myArray.Length;

            int element = 3;
           Console.WriteLine($"The element {element} is found at index: {LinearSearch(myArray, size, element)}");



        }
        
    }
}
