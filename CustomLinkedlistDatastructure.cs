using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  

namespace DatastructurePracticeProblem
{
        public class CustomLinkedList<T>
        {
            private class Node
            {
                public T Value { get; set; }
                public Node Next { get; set; }

                public Node(T value)
                {
                    Value = value;
                    Next = null;
                }
            }

            private Node head;

            public void Add(T value)
            {
                Node newNode = new Node(value);
                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    Node current = head;
                    while (current.Next != null)
                    {
                        current = current.Next;
                    }
                    current.Next = newNode;
                }
            }

            public bool Remove(T value)
            {
                if (head == null)
                    return false;

                if (head.Value.Equals(value))
                {
                    head = head.Next;
                    return true;
                }

                Node current = head;
                while (current.Next != null)
                {
                    if (current.Next.Value.Equals(value))
                    {
                        current.Next = current.Next.Next;
                        return true;
                    }
                    current = current.Next;
                }

                return false;
            }

            public void Print()
            {
                Node current = head;
                while (current != null)
                {
                    Console.Write(current.Value + " ");
                    current = current.Next;
                }
                Console.WriteLine();
            }
        }
    public class CustomLinkedlistDatastructure
    {
        public void CustomLinkedlist_Datastructure()
        {

            CustomLinkedList<string> stringList = new CustomLinkedList<string>();
            stringList.Add("Hello");
            stringList.Add("World");
            stringList.Add("!");
            stringList.Print(); // Output: Hello World !
            stringList.Remove("World");
            stringList.Print(); // Output: Hello !

        }
    }  
    }
