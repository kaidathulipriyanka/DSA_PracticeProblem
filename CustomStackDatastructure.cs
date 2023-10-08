using DatastructurePracticeProblem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  

namespace DatastructurePracticeProblem
{
    public class CustomStack<T>
    {
        private List<T> items;

        public CustomStack()
        {
            items = new List<T>();
        }

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty.");
            }

            int lastIndex = items.Count - 1;
            T item = items[lastIndex];
            items.RemoveAt(lastIndex);
            return item;
        }

        public T Peek()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty.");
            }

            return items[items.Count - 1];
        }

        public int Count
        {
            get { return items.Count; }
        }
    }
}

public class CustomStackDatastructure
{
    public void CustomStack_Datastructure()
    {

        CustomStack<int> intStack = new CustomStack<int>();

        intStack.Push(1);
        intStack.Push(2);
        intStack.Push(3);

        Console.WriteLine("Count: " + intStack.Count); // Output: Count: 3

        int poppedValue = intStack.Pop();
        Console.WriteLine("Popped Value: " + poppedValue); // Output: Popped Value: 3
        Console.WriteLine("Count after Pop: " + intStack.Count); // Output: Count after Pop: 2

        int peekedValue = intStack.Peek();
        Console.WriteLine("Peeked Value: " + peekedValue); // Output: Peeked Value: 2

        // Create a custom stack of strings
        CustomStack<string> stringStack = new CustomStack<string>();

        stringStack.Push("Hello");
        stringStack.Push("World");

        Console.WriteLine("Count: " + stringStack.Count); // Output: Count: 2

        string poppedString = stringStack.Pop();
        Console.WriteLine("Popped String: " + poppedString); // Output: Popped String: World
    }
}
