using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    class Program
    {
        static void Main(string[] args)
        {
            TestFindLastKthElement();

        }

        /// <summary>
        /// 测试寻找单链表中倒数第K个节点
        /// </summary>
        public static void TestFindLastKthElement()
        {
            SingleList<int> linklist = new SingleList<int>();

            linklist.InsertEnd(new SingleLinkNode<int>(1));
            linklist.InsertEnd(new SingleLinkNode<int>(2));
            linklist.InsertEnd(new SingleLinkNode<int>(3));
            linklist.InsertEnd(new SingleLinkNode<int>(4));
            linklist.InsertEnd(new SingleLinkNode<int>(5));
            linklist.InsertEnd(new SingleLinkNode<int>(6));
            linklist.InsertEnd(new SingleLinkNode<int>(7));
            linklist.InsertEnd(new SingleLinkNode<int>(8));

            SingleLinkNode<int> kthElement = linklist.FindLastKth(1);

            if (kthElement != null)
            {
                Console.WriteLine(string.Format("倒数第1个节点的Data值是:{0}", kthElement.Data));
            }

            kthElement = linklist.FindLastKth(3);

            if (kthElement != null)
            {
                Console.WriteLine(string.Format("倒数第3个节点的Data值是:{0}", kthElement.Data));
            }

            kthElement = linklist.FindLastKth(10);

            if (kthElement != null)
            {
                Console.WriteLine(string.Format("倒数第10个节点的Data值是:{0}", kthElement.Data));
            }
            else
            {
                Console.WriteLine("没有找到倒数第10个节点");
            }
        }

        /// <summary>
        /// 测试单链表中寻找第K个节点
        /// </summary>
        public static void TestFindKthElement()
        {
            SingleList<int> linklist = new SingleList<int>();

            linklist.InsertEnd(new SingleLinkNode<int>(1));
            linklist.InsertEnd(new SingleLinkNode<int>(2));
            linklist.InsertEnd(new SingleLinkNode<int>(3));
            linklist.InsertEnd(new SingleLinkNode<int>(4));
            linklist.InsertEnd(new SingleLinkNode<int>(5));
            linklist.InsertEnd(new SingleLinkNode<int>(6));
            linklist.InsertEnd(new SingleLinkNode<int>(7));
            linklist.InsertEnd(new SingleLinkNode<int>(8));

            SingleLinkNode<int> kthElement = linklist.FindKth(5);

            if (kthElement != null)
            {
                Console.WriteLine(string.Format("第K个节点的Data值是:{0}", kthElement.Data));
            }

        }

        /// <summary>
        /// 测试循环双链表的遍历 - 避免死循环
        /// </summary>
        public static void TestDoubleCycleLinkListVisit()
        {
            DoubleLinkNode<int> first = new DoubleLinkNode<int>(1);
            first.Next = null;
            first.previous = null;
            var node2 = new DoubleLinkNode<int>(2);
            first.Next = node2;
            node2.previous = first;

            var node3 = new DoubleLinkNode<int>(3);
            node2.Next = node3;
            node3.previous = node2;

            var node4 = new DoubleLinkNode<int>(4);
            node3.Next = node4;
            node4.previous = node3;

            var node5 = new DoubleLinkNode<int>(5);
            node4.Next = node5;
            node5.previous = node4;

            var node6 = new DoubleLinkNode<int>(6);
            node5.Next = node6;
            node6.previous = node5;
            node6.Next = first;

            first.previous = node6;

            first.Visit();
        }
        public static void TestDoubleLinkInsert()
        {
            DoubleLinkNode<int> first = new DoubleLinkNode<int>(1);

            DoubleLinkNode<int> second = new DoubleLinkNode<int>(2);

            first.previous = null;
            first.Next = second;
            second.previous = first;
            second.Next = null;

            first.InsertAfter(new DoubleLinkNode<int>(3) { Next = null, previous = null });
        }
        public static void TestSingleList()
        {
            SingleList<int> linkList = new SingleList<int>();

            linkList.InsertFirst(new SingleLinkNode<int>(1));
            linkList.InsertFirst(new SingleLinkNode<int>(2));

            linkList.print();

            SingleList<int> linkList2 = new SingleList<int>();

            linkList2.InsertEnd(new SingleLinkNode<int>(1));
            linkList2.InsertEnd(new SingleLinkNode<int>(2));

            linkList2.print();
        }
    }
}
