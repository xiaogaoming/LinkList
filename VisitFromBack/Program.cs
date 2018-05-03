using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitFromBack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkNode node1 = new MyLinkNode() { Data = 1 };
            MyLinkNode node2 = new MyLinkNode() { Data = 2 };
            MyLinkNode node3 = new MyLinkNode() { Data = 3 };
            MyLinkNode node4 = new MyLinkNode() { Data = 4 };
            MyLinkNode node5 = new MyLinkNode() { Data = 4 };
            MyLinkNode node6 = new MyLinkNode() { Data = 5 };
            MyLinkNode node7 = new MyLinkNode() { Data = 6 };

            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = node5;
            node5.Next = node6;
            node6.Next = node7;

            // node1.VisitFromBack();
            // MyLinkNode.VisitFromBackNByN(node1);

            //var node = MyLinkNode.DeleteTarget(node1, node3);
            // node.Visit();

            node1.Visit();

            var node = MyLinkNode.DeleteTargetByValue(node1, 1);
            node.Visit();

            MyLinkNode.DeleteTargetByValue(node1, 4);
            node1.Visit();

        }
    }
}
