using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.InteropServices;
using System.Diagnostics.Tracing;

namespace nmew
{
    class Node
    {
        public int data;
        public Node next;
    }
    class QueueLinked
    {
        Node front;
        Node rear;
        public QueueLinked()

        {
            front = rear = null;
        }
        bool IsEmpty()
        {
            return front == null;
        }
        public void Enqueue(int newdata)
        {
            Node insert = new Node();
            insert.data = newdata;
            if (rear == null)
            {
                front = rear = insert;
            }
            else
            {
                rear.next = insert;
                rear = insert;
            }
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }
            int data = front.data;
            front = front.next;
            if (front == null)
            {
                rear = null;
            }
            return data;
        }

        int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }
            return front.data;
        }
        public void PrintQueue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty.");
                return;
            }

            Console.WriteLine("Queue elements:");
            Node current = front;
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            Console.WriteLine();
        }
    }



    class Program
    {
        public static void Main(string[] args)
        {
            QueueLinked queue = new QueueLinked();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            queue.Dequeue();
            queue.Dequeue();
            
           queue.PrintQueue();
        }
    }
}
