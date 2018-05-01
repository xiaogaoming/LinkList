using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    public class SingleList<T>
    {
        public SingleLinkNode<T> Head { get; set; }

        public SingleList()
        {
            this.Head = new SingleLinkNode<T>();
        }

        /// <summary>
        /// 从头开始插入
        /// </summary>
        /// <param name="targetNode"></param>
        public void InsertFirst(SingleLinkNode<T> targetNode)
        {
            // 第一方法： head的next先保存下来
            // head.next 重新调整
            // targetnode.next = head.next

            //if (targetNode != null)
            //{
            //    SingleLinkNode<T> first = this.Head.Next;
            //    this.Head.Next = targetNode;
            //    targetNode.Next = first;
            //}

            //第二种做法，先将targetnode。next指向下一个节点，再修改head
            if (targetNode != null)
            {
                targetNode.Next = this.Head.Next;
                this.Head.Next = targetNode;
            }

        }

        /// <summary>
        /// 从尾开始插入
        /// </summary>
        /// <param name="targetNode"></param>
        public void InsertEnd(SingleLinkNode<T> targetNode)
        {
            SingleLinkNode<T> p = this.Head;

            while (p.Next != null)
            {
                p = p.Next;
            }

            p.Next = targetNode;
        }

        public void print()
        {
            SingleLinkNode<T> p = this.Head.Next;

            while (p != null && p != this.Head)
            {
                Console.Write(p.Data + "==>");
                p = p.Next;
            }
            Console.WriteLine();
        }

        /// <summary>
        /// 寻找当前节点开始的第K个节点并返回
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        public SingleLinkNode<T> FindKth(int k)
        {
            int count = 1;

            SingleLinkNode<T> p = this.Head.Next;

            while (p != null && p.Next != this.Head && count < k)
            {
                count++;
                p = p.Next;
            }

            if (count == k)
            {
                return p;
            }

            return null;
        }

        /// <summary>
        /// 寻找单链表当中的倒数第K个节点
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        public SingleLinkNode<T> FindLastKth(int k)
        {
            SingleLinkNode<T> first = this.Head.Next;
            SingleLinkNode<T> second = this.Head.Next;

            int countFirst = 1;

            while (first != null && first.Next != null && countFirst < k)
            {
                countFirst++;
                first = first.Next;
            }

            if (countFirst == k)
            {
                while (first != null && first.Next != null)
                {
                    first = first.Next;
                    second = second.Next;
                }

                return second;
            }

            return null;
        }
              
    }
}
