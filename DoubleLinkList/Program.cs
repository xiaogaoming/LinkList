using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkList node1 = new DoubleLinkList(1);
            node1.InsertAtEnd(new DoubleLinkList(2));
            node1.InsertAtEnd(new DoubleLinkList(3));
            DoubleLinkList node4 = new DoubleLinkList(4);
            node1.InsertAtEnd(node4);
            node1.InsertAtEnd(new DoubleLinkList(5));
            node1.InsertAtEnd(new DoubleLinkList(6));

            DoubleLinkList node7 = new DoubleLinkList(7);
            node1.InsertAtEnd(node7);

            node1.Delete(node4);

            node1.Delete(node7);
        }
    }
}
