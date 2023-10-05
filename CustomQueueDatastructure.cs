using DatastructurePracticeProblem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatastructurePracticeProblem
{ 
       public class CustomQueue<T>
        {
            private LinkedList<T> items = new LinkedList<T>();

            public void Enqueue(T item)
            {
                items.AddLast(item);
            }

            public T Dequeue()
            {
                if (IsEmpty())
                {
                    throw new InvalidOperationException("The queue is empty.");
                }

                T item = items.First.Value;
                items.RemoveFirst();
                return item;
            }

            public T Peek()
            {
                if (IsEmpty())
                {
                    throw new InvalidOperationException("The queue is empty.");
                }

                return items.First.Value;
            }

            public bool IsEmpty()
            {
                return items.Count == 0;
            }

            public int Count()
            {
                return items.Count;
            }
        }
    }
    
   public class CustomQueueDatastructure
{
    public void Datastructure_PracticeProblem()
{
        CustomQueue<int> intQueue = new CustomQueue<int>();
        intQueue.Enqueue(1);
        intQueue.Enqueue(2);
        intQueue.Enqueue(3);

        Console.WriteLine("Dequeue: " + intQueue.Dequeue());
        Console.WriteLine("Peek: " + intQueue.Peek());
        Console.WriteLine("Queue Count: " + intQueue.Count());

        CustomQueue<string> stringQueue = new CustomQueue<string>();
        stringQueue.Enqueue("Hello");
        stringQueue.Enqueue("World");

        Console.WriteLine("Dequeue: " + stringQueue.Dequeue());
        Console.WriteLine("Peek: " + stringQueue.Peek());
        Console.WriteLine("Queue Count: " + stringQueue.Count());
    }
}
