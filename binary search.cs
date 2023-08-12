using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Xml.Schema;

namespace nmew
{
    

    class Program
    {

        static int BinarySearch(int[] arr, int size, int element)
        {
            int low = 0;
            int mid;
            int high = size-1;
            // start searching 
            while (low <= high)
            {
                mid = (low + high) / 2;

                if (arr[mid] == element)            // element finding part
                {
                    return mid;
                }
                if (arr[mid] < element)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;                  // (mid+1) & (mid-1) isliye kyuki it is not inclusive of the previous range(i.e. low, mid)
                }
            }
            // end searching 
            return -1;
        } 
        public static void Main(string[] args)
        {
            int[] myArray = { 1, 25, 36, 45, 58, 335, 560 };
            int size = myArray.Length;

            int element = 25;
           Console.WriteLine($"The element {element} is found at index: {BinarySearch(myArray, size, element)}");



        }
        
    }
}
