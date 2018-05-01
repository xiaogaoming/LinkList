using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossLinkList
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkNode first = new SingleLinkNode(1);
            SingleLinkNode node2 = new SingleLinkNode(2);
            SingleLinkNode node3 = new SingleLinkNode(3);
            SingleLinkNode node4 = new SingleLinkNode(4);
            SingleLinkNode node5 = new SingleLinkNode(5);
            SingleLinkNode node6 = new SingleLinkNode(6);

            first.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = node5;
            node5.Next = node6;

            SingleLinkNode second = new SingleLinkNode(11);
            SingleLinkNode node10 = new SingleLinkNode(10);
            SingleLinkNode node9 = new SingleLinkNode(9);
            SingleLinkNode node8 = new SingleLinkNode(8);

            second.Next = node10;
            node10.Next = node9;
            node9.Next = node8;

            node8.Next = node3;

            SingleLinkNode crossNode = first.FindCrossNode(second);

            Console.WriteLine(crossNode.Data);

        }
    }
}
