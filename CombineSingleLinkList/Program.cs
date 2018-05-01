using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombineSingleLinkList
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkNode first = new SingleLinkNode(1);
            first.InsertAfter(3);
            first.InsertAfter(5);
            first.InsertAfter(6);
            first.InsertAfter(7);

            SingleLinkNode second = new SingleLinkNode(2);
            second.InsertAfter(4);
            second.InsertAfter(5);
            second.InsertAfter(8);
            second.InsertAfter(9);

            SingleLinkNode result = first.Combine(second);

            SingleLinkNode p = result;

            while (p != null)
            {
                Console.Write(p.Data + "==>");
                p = p.Next;
            }

        }
    }
}
