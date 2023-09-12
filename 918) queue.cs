using System;
using System.Collections.Generic;



namespace nmew
{
   class Program
    {
        
        public static void Main(string[] args)
        {
            
            Queue<int> queue = new Queue<int>();    // Queue<int> queue = new Queue<int>(new[] {1,2,3}); ------> use this for faster one line code for adding elements in queue
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            foreach (int i in queue)
            {
                Console.WriteLine(i);
            }

        }
    }
}
