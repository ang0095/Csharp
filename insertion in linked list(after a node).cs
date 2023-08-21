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

         static Node InsertAfterNode(Node head, Node prevNode, int newData)    // yahaa first node(i.e. head) nhi include kare toh bhi chalega
        {
            Node insert = new Node();
            insert.data = newData;
            insert.next = prevNode.next;
            prevNode.next = insert;
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

            InsertAfterNode(head, third, 18);
            LinkedListTraversal(head);

        }
        
    }
}
