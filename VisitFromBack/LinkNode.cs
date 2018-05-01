using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitFromBack
{
    public class MyLinkNode
    {
        public int Data { get; set; }

        public MyLinkNode Next { get; set; }

        /// <summary>
        /// 递归倒序打印 - 递归解法
        /// </summary>
        public void VisitFromBack()
        {
            if (this.Next != null)
            {
                this.Next.VisitFromBack();
                Console.Write(this.Data + "=>");
            }
            else
            {
                Console.Write(this.Data + "=>");
            }


        }

        /// <summary>
        /// 倒序打印单链表 - N*N复杂度
        /// </summary>
        /// <param name="node"></param>
        public static void VisitFromBackNByN(MyLinkNode node)
        {
            if (node != null)
            {
                MyLinkNode end = null;
                MyLinkNode p = node;

                while (end != node)
                {
                    p = node;

                    while (p.Next != end)
                    {
                        p = p.Next;
                    }
                    Console.Write(p.Data + "=>");
                    end = p;
                }
            }
        }

        /// <summary>
        /// 在已知的单链表linklist里面，删除目标节点node
        /// </summary>
        /// <param name="linkList"></param>
        /// <param name="node"></param>
        public static void DeleteTarget(MyLinkNode linkList, MyLinkNode node)
        {
            if (linkList != null && node != null)
            {
                MyLinkNode p = linkList;

                while (p != null && p.Next != node)
                {
                    p = p.Next;
                }

                ///说明我们找到了目标节点
                if (p.Next == node)
                {
                    p.Next = p.Next.Next;
                }
            }
        }

        /// <summary>
        /// 在给定的单链表中删除所有等于target的值的节点
        /// </summary>
        /// <param name="linkList"></param>
        /// <param name="target"></param>
        public static void DeleteTargetByValue(MyLinkNode linkList, int target)
        {
            if (linkList != null)
            {
                MyLinkNode p = linkList;

                while (p.Next != null)
                {
                    if (p.Next.Data == target)
                    {
                        p.Next = p.Next.Next;
                    }
                    else
                    {
                        p = p.Next;
                    }
                }
            }
        }

        public void Visit()
        {
            MyLinkNode p = this;
            while (p != null)
            {
                Console.Write(p.Data + "=>");
                p = p.Next;
            }

            Console.WriteLine();
        }
    }
}
