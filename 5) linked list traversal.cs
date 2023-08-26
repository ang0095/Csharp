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

        static Node DeleteAtMiddle(Node head, int index)
        {
            Node p = head;
            for(int i = 0; i < index-1; i++)
            {
                p = p.next;
            }

            Node q = p.next;
            p.next = q.next;
            q.next = null;

            return head;
        }

        static Node DeleteAtEnd(Node head)
        {
            Node p = head;
            Node q = head.next;
            while (q.next != null)
            {
                p = p.next;
                q = q.next;
            }

            p.next = null;

            return head;

            // slightly different method where we use element.next.next to address last element pointing to null

            // Node SecondToLast = head;
            // while (SecondToLast.next.next != null)
            // {
            //    SecondToLast = SecondToLast.next;
            // }

            // SecondToLast.next = null;

            // return head;
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
            head.data = 5;
            head.next = second;
            // linking other nodes sequentially
            second.data = 6;
            second.next = third;

            third.data = 9;
            third.next = fourth;

            fourth.data = 1;
            fourth.next = fifth;

            fifth.data = 16;
            fifth.next = sixth;

            sixth.data = 58;
            sixth.next = null;

            Console.WriteLine("Linked list before deletion");
            LinkedListTraversal(head);
            Console.WriteLine("\n");

            head = DeleteFirst(head);
            Console.WriteLine("Linked list after deletion(index 0)");
            LinkedListTraversal(head);
            Console.WriteLine("\n");

            Console.WriteLine("Linked list after deletion(at given index)");
            DeleteAtMiddle(head, 3);
            LinkedListTraversal(head);
            Console.WriteLine("\n");

            Console.WriteLine("Linked list after deletion(at the end)");
            DeleteAtEnd(head);
            LinkedListTraversal(head);
            Console.WriteLine("\n");

        }

    }
}
