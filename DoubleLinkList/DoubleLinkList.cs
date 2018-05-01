using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkList
{
    public class DoubleLinkList
    {
        public int Data { get; set; }

        public DoubleLinkList Next { get; set; }

        public DoubleLinkList Last { get; set; }

        public DoubleLinkList(int data)
        {
            this.Data = data;
        }

        public void InsertAtEnd(DoubleLinkList node)
        {
            if (node != null)
            {
                DoubleLinkList p = this;

                while (p.Next != null)
                {
                    p = p.Next;
                }

                p.Next = node;
                node.Last = p;
                node.Next = null;
            }
        }

        public void Delete(DoubleLinkList node)
        {
            if (node != null)
            {
                DoubleLinkList p = this;

                // 当p不是最后一个节点，p也不是目标节点
                // 我们就继续往后扫描
                while (p.Next != null && p != node)
                {
                    p = p.Next;
                }

                if (p == node)
                {
                    p.Last.Next = p.Next;

                    if (p.Next != null)
                    {
                        p.Next.Last = p.Last;
                    }

                    //if (p.Next != null)
                    //{
                    //    p.Last.Next = p.Next;
                    //    p.Next.Last = p.Last;
                    //}
                    //else
                    //{
                    //    p.Last.Next = p.Next;
                    //}
                }
            }
        }
    }
}
