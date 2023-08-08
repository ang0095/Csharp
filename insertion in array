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
       static void display(int[] arr, int n)
        {
            // code for Traversal
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
                
            }
        }

        static int IndexInsertion(int[] arr, int used, int element, int capacity, int index)
        {
            //code for Insertion
            if(used >= capacity)
            {
                return -1;
            }
            for(int i = used; i >=index; i--)
            {
                arr[i+1] = arr[i];
            }
            arr[index] = element;
            return 1;

        }
        public static void Main(string[] args)
        {
            int[] arr = new int[100];
            arr[0] = 1;
            arr[1] = 25;
            arr[2] = 36;
            arr[3] = 58;
            int used = 4, element = 16, index = 3;
            display(arr, used);

            Console.WriteLine("\n");
            IndexInsertion(arr, used, element, 100, index);
            used += 1;
            for(int i = 0; i < used; i++)
            {
                Console.WriteLine(arr[i]);
            }
            
        }
        
    }
}
