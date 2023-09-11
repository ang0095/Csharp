using System;
using System.Collections.Generic;



namespace nmew
{
   class Program
    {
        
        public static void Main(string[] args)
        {
            
            Queue<int> queue = new Queue<int>();    
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
