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

        public DoubleLinkList Delete(DoubleLinkList node)
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
                    // 待删除的节点是第一个节点
                    // 需要特别处理
                    if (p == this)
                    {
                        // 这个时候表明该算法的签名有问题哈，我们需要把它改成有返回值的
                        // 否则我们不能删除自己

                        p = p.Next;
                        p.Last = null;

                        return p;
                    }
                    else
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
            return this;
        }
    }
}
