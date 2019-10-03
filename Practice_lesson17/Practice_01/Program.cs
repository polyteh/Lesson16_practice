using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_01
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListGeneric<int> myLinkedList = new LinkedListGeneric<int>();

            for (int i = 0; i < 10; i++)
            {
                myLinkedList.AddItem(i,i);
            }

            Console.WriteLine("Initial linked list");
            foreach (var item in myLinkedList)
            {
                Console.WriteLine(item);
            }

            int indexToDelete = 3;
            Console.WriteLine($"Linked list without element with index {indexToDelete}");
            myLinkedList.DeleteItem(indexToDelete);
            foreach (var item in myLinkedList)
            {
                Console.WriteLine(item);
            }

            indexToDelete = 0;
            Console.WriteLine($"Linked list without element with index {indexToDelete}");
            myLinkedList.DeleteItem(indexToDelete);
            foreach (var item in myLinkedList)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();

        }
    }
}
