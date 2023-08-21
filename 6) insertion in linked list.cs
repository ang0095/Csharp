using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Xml.Schema;
using System.Runtime.Remoting.Messaging;

namespace nmew
{
    
    class Node
    {
        public int data;
        public Node next;
    }
    class Program
    {

        static void LinkedListTraversal(Node ptr)
        {
            while (ptr != null)
            {
                Console.WriteLine($"Element: {ptr.data}");
                ptr = ptr.next;
            }
        } 

       static Node InsertAtFirst(Node head, int newData)
        {
            Node insert = new Node();
            insert.data = newData;
            insert.next = head;
            return insert;
        }

        static Node InsertInBetween(Node head, int newData, int index)
        {
            Node insert = new Node();
            insert.data = newData;
            Node p = head;
            for(int i = 0; i<index-1; i++)
            {
                p = p.next;
            }
            insert.next = p.next;
            p.next = insert;

            return insert;
        }

         static Node InsertAtEnd(Node head, int newData)
        {
            Node insert = new Node();
            insert.data = newData;
            Node p = head;
            while(p.next != null)
            {
                p=p.next;
            }
            p.next = insert;
            insert.next = null;
            return insert;
        }
        public static void Main(string[] args)
        {
            Node head = new Node();
            Node second = new Node();
            Node third = new Node();
            Node fourth = new Node();
            // linking first and second nodes
            head.data = 7;
            head.next = second;
            // linking other nodes sequentially
            second.data = 11;
            second.next = third;

            third.data = 41;
            third.next = fourth;

            fourth.data = 66;
            fourth.next = null;
            
            

            LinkedListTraversal(head);
            Console.WriteLine("\n");

            head = InsertAtFirst(head, 15);
            LinkedListTraversal(head);
            Console.WriteLine("\n");

            InsertInBetween(head, 16, 2);
            LinkedListTraversal(head);
            Console.WriteLine("\n");

            InsertAtEnd(head, 17);
            LinkedListTraversal(head);


        }
        
    }
}
