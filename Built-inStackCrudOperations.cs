using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatastructurePracticeProblem
{
    internal class Built_inStackCrudOperations
    {
        public void Built_inStackCrud_Operations()
        {

            Stack<int> stack = new Stack<int>();

            // Add elements 
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            // Display the elements 
            Console.WriteLine("Stack elements:");
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }

            // Update the top element of the stack
            if (stack.Count > 0)
            {
                int topElement = stack.Pop();
                int updatedValue = topElement * 2;
                stack.Push(updatedValue);
                Console.WriteLine($"Updated top element to: {updatedValue}");
            }

            // Display the elements
            Console.WriteLine("Updated stack elements:");
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }

            // Remove an element 
            if (stack.Count > 0)
            {
                int removedElement = stack.Pop();
                Console.WriteLine($"Removed element from the stack: {removedElement}");
            }

            // Display the elements 
            Console.WriteLine("Stack elements after removal:");
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}