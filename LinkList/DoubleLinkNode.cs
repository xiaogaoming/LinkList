using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    public class DoubleLinkNode<T>
    {
        public T Data { get; set; }

        public DoubleLinkNode<T> previous { get; set; }

        public DoubleLinkNode<T> Next { get; set; }

        public DoubleLinkNode(T data)
        {
            this.Data = data;
            this.previous = this;
            this.Next = this;
        }

        /// <summary>
        /// 当前节点后插入一个新的节点
        /// </summary>
        /// <param name="targetNode"></param>
        public void InsertAfter(DoubleLinkNode<T> targetNode)
        {
            if (targetNode != null)
            {
                targetNode.previous = this;
                targetNode.Next = this.Next;

                if (targetNode.Next != null) //this.next !=null
                {
                    targetNode.Next.previous = targetNode;
                }

                this.Next = targetNode;
            }
        }

        /// <summary>
        /// 循环链表的遍历
        /// </summary>
        public void Visit()
        {
            Console.Write(this.Data);

            DoubleLinkNode<T> p = this.Next;

            while (p != null && p != this)
            {
                Console.Write("==> " + p.Data);
                p = p.Next;
            }
        }
    }
}
