using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkListDuicheng
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode() { Data = 10 };

            TreeNode six = new TreeNode() { Data = 6 };
            TreeNode four = new TreeNode() { Data = 4 };
            TreeNode eight = new TreeNode() { Data = 8 };

            TreeNode node14 = new TreeNode() { Data = 14 };
            TreeNode node12 = new TreeNode() { Data = 12 };
            TreeNode node16 = new TreeNode() { Data = 16 };

            root.Left = six;
            root.Right = node14;

            six.Left = four;
            six.Right = eight;

            node14.Left = node12;
            node14.Right = node16;

            DoubleLinkNode result = root.ConvertTreeToLinkList();

            DoubleLinkNode p = result;

            while (p != null)
            {
                Console.Write(p.Data + "==>");
                p = p.Next;
            }
        }

        public static void TestDuichen()
        {
            DoubleLinkNode first = new DoubleLinkNode(1);
            DoubleLinkNode node2 = new DoubleLinkNode(2);
            DoubleLinkNode node3 = new DoubleLinkNode(10);

            first.Next = node2;
            node2.Last = first;

            node2.Next = node3;
            node3.Last = node2;

            node3.Next = first;
            first.Last = node3;

            bool result = first.IsDuicheng();

            DoubleLinkNode second = new DoubleLinkNode(1);
            DoubleLinkNode node21 = new DoubleLinkNode(2);
            DoubleLinkNode node31 = new DoubleLinkNode(3);
            DoubleLinkNode node41 = new DoubleLinkNode(30);
            DoubleLinkNode node51 = new DoubleLinkNode(2);
            DoubleLinkNode node61 = new DoubleLinkNode(1);

            second.Next = node21;
            node21.Last = second;

            node21.Next = node31;
            node31.Last = node21;

            node31.Next = node41;
            node41.Last = node31;

            node41.Next = node51;
            node51.Last = node41;

            node51.Next = node61;
            node61.Last = node51;

            node61.Next = second;
            second.Last = node61;

            result = second.IsDuicheng();
        }
    }
}
