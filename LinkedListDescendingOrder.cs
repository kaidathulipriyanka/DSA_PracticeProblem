using DatastructurePracticeProblem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  

namespace DatastructurePracticeProblem
{
    internal class InsertInDescendingOrder
    {
        public void InsertIn_DescendingOrder()
        {

            LinkedList<int> descendingList = new LinkedList<int>();

            // Insert elements in descending order
            InsertInDescendingOrder_(descendingList, 5);
            InsertInDescendingOrder_(descendingList, 8);
            InsertInDescendingOrder_(descendingList, 2);
            InsertInDescendingOrder_(descendingList, 10);
            InsertInDescendingOrder_(descendingList, 3);

            foreach (var item in descendingList)
            {
                Console.WriteLine(item);
            }
        }
        public void InsertInDescendingOrder_(LinkedList<int> list, int value)
        {
            var currentNode = list.First;

            while (currentNode != null && value > currentNode.Value)
            {
                currentNode = currentNode.Next;
            }

            if (currentNode == null)
            {
                list.AddLast(value); // Insert at the end if value is the largest.
            }
            else
            {
                list.AddBefore(currentNode, value); // Insert before the larger element.
            }
        }
    }
}
