using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Xml.Schema;
using System.Runtime.InteropServices;

namespace nmew
{

    class Node
    {
        public int data;
        public Node next;
        public Node prev;
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

            insert.prev = head.prev;
            insert.next = head;
            head = insert;
            return head;
        }


        public static void Main(string[] args)
        {
            Node head = new Node();
            Node second = new Node();
            Node third = new Node();
            Node fourth = new Node();
            Node fifth = new Node();
            Node sixth = new Node();

            // linking first and second nodes
            head.data = 7;
            head.next = second;
            head.prev = null;
            // linking other nodes sequentially
            second.data = 11;
            second.next = third;
            second.prev = head;

            third.data = 51;
            third.next = fourth;
            third.prev = second;

            fourth.data = 66;
            fourth.next = fifth;
            fourth.prev = third;

            fifth.data = 16;
            fifth.next = sixth;
            fifth.prev = fourth;

            sixth.data = 58;
            sixth.next = null;
            sixth.prev = fifth;


            LinkedListTraversal(head);
            Console.WriteLine("\n");

            head = InsertAtFirst(head, 19);
            LinkedListTraversal(head);

        }

    }
}
