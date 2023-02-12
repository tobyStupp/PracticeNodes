using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4;

namespace Practice_nodes
{
    class ManageLinkedList
    {
        public static Node<int> GenerateRandomLinkedList(int size = 10)
        {
            // generates and returns a random List
            throw new NotImplementedException();
        }
        public static void PrintLinkedList (Node<int> p)
        {
            if (p.GetNext()==null)
                Console.WriteLine(p.GetValue());
            else
            {
                Console.Write(p.GetValue().ToString() + ", ");
                PrintLinkedList(p.GetNext());
            }
        }

    }
}
