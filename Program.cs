using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4;

namespace Practice_nodes
{
    class Program
    {
        public static Node<int> Sort(Node<int> head)
        {
            //takes the Node after last Node and inserts it in its sorted position
            // assert that all nodes between head and last are sorted
            // the method returns the first Node (which might change) of the sorted Linked List
            // throw new NotImplementedException();
            throw new NotImplementedException();

        }
        //public static  Node<int> Sort (Node<int> head)
        //{
        //    Node<int> dummy = new Node<int>(int.MinValue, head);
        //    Node<int> last = head;
        //    while (last!=null)
        //    {
        //        last = InsertSorted(dummy, last);
               
        //    }
        //    return dummy.GetNext();
        //}
        public static void Join (Node<int> a, Node <int> b)
        {
            // adds the linked list starting at b at the end of the link list starting from a
            throw new NotImplementedException();
        }
        public static  Node<int> ReturnEven (Node<int> head)
        {
            // removes all the even numbers from linked list starting at head.
            // assert that head is not even
            // the method returns all the even numbers in a new Linked list
            throw new NotImplementedException();
        }
        public int Pivot (Node<int> first)
        {
            // returns how many nodes have values that are smaller than the value of the first Node
            //it also rearranges the Linked list in a way that all the numbers less of the first value is on its left side and all greater on the right side
            // it than swaps the value of the first with the last Node with a smaller value therefore having the linked list partially sorted
            throw new NotImplementedException();
        }
        static void Main(string[] args)
        {
            //don't forget to implement the Generated Random List 
            Node<int> list = ManageLinkedList.GenerateRandomLinkedList(5);
            ManageLinkedList.PrintLinkedList(list);
            /*
            Node<int> list1 = ManageLinkedList.GenerateRandomLinkedList(5);
            ManageLinkedList.PrintLinkedList(list1);
            Join(list, list1);
            ManageLinkedList.PrintLinkedList(list);
            */
            list = Sort(list);
            ManageLinkedList.PrintLinkedList(list);
            //make sure that  list starts with uneven value
            //========================================
            //Node<int> even = ReturnEven( list);
            //ManageLinkedList.PrintLinkedList(even);
            Console.ReadKey();

        }
    }
}
