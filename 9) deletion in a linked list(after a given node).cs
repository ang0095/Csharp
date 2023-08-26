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
        
         static Node DeleteAfterNode(Node head,int Value)
        {
            Node p = head;
            Node q = head.next;
           while(q.data != Value && q.next != null)
            {
                p = p.next;
                q = q.next;
            }

           if(q.data == Value)
            {
                p.next = q.next;
                q.next = null;
            }
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
            // linking other nodes sequentially
            second.data = 11;
            second.next = third;

            third.data = 41;
            third.next = fourth;

            fourth.data = 66;
            fourth.next = fifth;
            
            fifth.data = 16;
            fifth.next = sixth;

            sixth.data = 58;
            sixth.next = null;

            LinkedListTraversal(head);
            Console.WriteLine("\n");

            DeleteAfterNode(head, 51);
            LinkedListTraversal(head);

        }
        
    }
}
