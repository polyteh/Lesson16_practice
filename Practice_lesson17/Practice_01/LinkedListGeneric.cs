using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_01
{
    public class LinkedListGeneric<T>:IEnumerable<T>
    {
        private LinkedList<T> myLinkedList;
        public LinkedListGeneric()
        {
            myLinkedList = new LinkedList<T>();
        }
        public void AddItem(T newItem, int index)
        {
            LinkedListNode<T> insertAfterNode = myLinkedList.First;

            if (myLinkedList.Count==0)
            {
                myLinkedList.AddFirst(newItem);               
            }

            for (int i = 0; (myLinkedList.Count != 0) &&(i <= index)&&(insertAfterNode!=null); i++)
            {
               
                if (i==(index-1))
                {
                    myLinkedList.AddAfter(insertAfterNode, newItem);
                    break;
                }
                insertAfterNode = insertAfterNode.Next;

            }

        }

        public void DeleteItem(int index)
        {
            LinkedListNode<T> nodeToDelete = myLinkedList.First;
            for (int i = 0; (i <= index) && (nodeToDelete != null); i++)
            {

                if (i==index)
                {
                    myLinkedList.Remove(nodeToDelete);
                    break;
                }
                nodeToDelete = nodeToDelete.Next;
            }


        }

        public IEnumerator<T> GetEnumerator()
        {
            return myLinkedList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return myLinkedList.GetEnumerator();
        }
    }
}
