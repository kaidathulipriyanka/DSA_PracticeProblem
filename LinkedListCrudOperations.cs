using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  

namespace DatastructurePracticeProblem
{
    internal class LinkedListCrudOperations
    {
        public void Builtin_LinkedListCrudOperations() {

                LinkedList<string> linkedList = new LinkedList<string>();

                // Create - 
                linkedList.AddLast("Apple");
                linkedList.AddLast("Banana");
                linkedList.AddLast("Cherry");

                // Read - 
                Console.WriteLine("LinkedList Elements:");
                foreach (var item in linkedList)
                {
                    Console.WriteLine(item);
                }

                // Update - 
                var nodeToUpdate = linkedList.Find("Banana");
                if (nodeToUpdate != null)
                {
                    linkedList.AddAfter(nodeToUpdate, "Grapes");
                    Console.WriteLine("\nLinkedList Elements after update:");
                    foreach (var item in linkedList)
                    {
                        Console.WriteLine(item);
                    }
                }
                else
                {
                    Console.WriteLine("\nElement not found for update.");
                }

                // Delete - 
                var nodeToDelete = linkedList.Find("Cherry");
                if (nodeToDelete != null)
                {
                    linkedList.Remove(nodeToDelete);
                    Console.WriteLine("\nLinkedList Elements after delete:");
                    foreach (var item in linkedList)
                    {
                        Console.WriteLine(item);
                    }
                }
                else
                {
                    Console.WriteLine("\nElement not found for delete.");
                }
            }
        }

 }
