using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  

namespace DatastructurePracticeProblem
{
    public class Built_inQueueCrudOperations
    {
        public void Built_inQueueCrud_Operations()
        {
            Queue queue = new Queue();

            // Create: Add items 
            queue.Enqueue("Item 1");
            queue.Enqueue("Item 2");
            queue.Enqueue("Item 3");

            // Read: Print all items in the queue
            Console.WriteLine("Queue Contents:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            // Delete: Remove 
            string itemToRemove = "Item 2";
            if (queue.Contains(itemToRemove))
            {
                Queue tempQueue = new Queue();
                while (queue.Count > 0)
                {
                    string item = (string)queue.Dequeue();
                    if (item != itemToRemove)
                    {
                        tempQueue.Enqueue(item);
                    }
                }
                queue = tempQueue;
                Console.WriteLine($"{itemToRemove} has been removed from the queue.");
            }
            else
            {
                Console.WriteLine($"{itemToRemove} not found in the queue.");
            }

            // Read: Print the updated queue
            Console.WriteLine("Updated Queue Contents:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
