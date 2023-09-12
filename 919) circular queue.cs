using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.InteropServices;
using System.Diagnostics.Tracing;

namespace nmew
{
    public class CircularQueue<T>
    {
        private T[] queue; // private T[] queue; is declaring a private array that will hold elements of the generic type T.
        private int front;
        private int rear;
        private int size;
        private int capacity;


        public CircularQueue(int capacity) // constructor
        {
            this.capacity = capacity;
            this.queue = new T[capacity];
            this.front = this.rear = -1; // this means the queue is initially empty
            this.size = 0;
        }
        public bool IsEmpty()
        {
            return this.size == 0;
        }
        public bool IsFull()
        {
            return this.size == this.capacity; 
        }

        public void Enqueue(T value)
        {
            if(IsFull())
            {
                Console.WriteLine("Queue is full. Cannot enqueue");
            }
            if(IsEmpty())
            {
                front = rear = 0;
            }
            else
            {
                rear = (rear + 1) % capacity;
            }
            queue[rear] = value;
            size++;
        }
        public T Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty. Cannot dequeue.");
                return default(T); // Return default value for type T
            }
            T value = queue[front];
            if(front == rear)
            {
                front = rear = -1;
            }
            else
            {
                front = (front + 1) % capacity;
            }
            size--;
            return value;
        }
        public T Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty. Cannot peek.");
                return default(T);
            }
            return queue[front]; // jo first element enter hua tha queue me uski value return karega
        }
        public int Count()
        {
            return size;
        }
        public void PrintQueue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty.");
                return;
            }

            Console.WriteLine("Queue elements:");
            int current = front;
            do
            {
                Console.WriteLine(queue[current]);
                current = (current + 1) % capacity;
            } 
            while (current != (rear + 1) % capacity);
        }


    }

   class Program
    {
        
        public static void Main(string[] args)
        {

            CircularQueue<int> queue = new CircularQueue<int>(5); //  created object(named queue) of the class CircularQueue

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            queue.Dequeue();
            queue.Dequeue();

            /* foreach (int i in queue) // In order to enable the use of foreach, you would need to implement the IEnumerable<T> interface in your CircularQueue class, which requires defining an enumerator (typically using an iterator method). 
             {
                 Console.WriteLine(i);
             }*/
            // instead of using foreach loop, we have used another method called PrintQueue in the CircularQueue class
          
           queue.PrintQueue();
        }
    }
}
