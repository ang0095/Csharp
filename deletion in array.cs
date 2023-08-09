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

        static int IndexDeletion(int[] arr, int used, int index)
        {
            //code for Insertion
            
            for(int i = index; i <=used-1; i++)
            {
                arr[i] = arr[i+1];
            }
            
            return 1;

        }
        public static void Main(string[] args)
        {
            int[] arr = new int[100];
            arr[0] = 1;
            arr[1] = 25;
            arr[2] = 36;
            arr[3] = 58;
            int used = 4, index = 1;
            display(arr, used);
            
            IndexDeletion(arr, used, index);
            used -= 1;
            for(int i = 0; i < used; i++)     // we can use display(arr, used) as well.
            {
                Console.WriteLine(arr[i]);
            }

            
            
        }
        
    }
}
