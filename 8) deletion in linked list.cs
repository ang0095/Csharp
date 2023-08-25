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

        static Node DeleteFirst(Node head)
        {
            if(head == null)
            {
                Console.WriteLine("Linked list is empty");
                return null;
            }

            
            Node newHead = head.next;  // Update the new head
            head.next = null;         // Disconnect the previous head
            return newHead;

        }
        public static void Main(string[] args)
        {
            Node head = new Node();
            Node second = new Node();
            Node third = new Node();
            Node fourth = new Node();

            // linking first and second nodes
            head.data = 5;
            head.next = second;
            // linking other nodes sequentially
            second.data = 6;
            second.next = third;

            third.data = 9;
            third.next = fourth;

            fourth.data = 1;
            fourth.next = null;

            Console.WriteLine("Linked list before deletion");
            LinkedListTraversal(head);

            head = DeleteFirst(head);
            Console.WriteLine("Linked list after deletion");
            LinkedListTraversal(head);

        }

    }
}
