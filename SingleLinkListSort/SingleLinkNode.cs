using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkListSort
{
    public class SingleLinkNode
    {
        public int Data { get; set; }

        public SingleLinkNode Next { get; set; }

        public SingleLinkNode(int data)
        {
            this.Data = data;
        }

        public SingleLinkNode Insert(int data)
        {
            SingleLinkNode p = this;

            if (p.Data < data)
            {
                while (p != null && p.Next != null && p.Next.Data < data)
                {
                    p = p.Next;
                }

                SingleLinkNode newNode = new SingleLinkNode(data);

                if (p != null && p.Next != null && p.Next.Data >= data)
                {
                    newNode.Next = p.Next;
                    p.Next = newNode;
                }
                else
                {
                    if (p != null && p.Next == null)
                    {
                        p.Next = newNode;
                    }
                }

                return this;
            }
            else
            {
                SingleLinkNode newNode = new SingleLinkNode(data);
                newNode.Next = this;
                return newNode;
            }
        }

        public void Split(out SingleLinkNode jiHead, out SingleLinkNode ouHead)
        {
            jiHead = null;
            ouHead = null;

            SingleLinkNode jiLast = null;
            SingleLinkNode ouLast = null;

            SingleLinkNode p = this;

            while (p != null)
            {
                if (p.Data % 2 == 0) //oushu
                {
                    if (ouHead == null)
                    {
                        ouHead = p;
                        ouLast = p;
                    }
                    else
                    {
                        ouLast.Next = p;
                        ouLast = ouLast.Next;
                    }
                }
                else
                {
                    if (jiHead == null)
                    {
                        jiHead = p;
                        jiLast = p;
                    }
                    else
                    {
                        jiLast.Next = p;
                        jiLast = jiLast.Next;
                    }
                }

                p = p.Next;
            }

            if (jiLast != null) { jiLast.Next = null; }

            if (ouLast != null) { ouLast.Next = null; }
        }

        public SingleLinkNode Revert()
        {
            SingleLinkNode p = this;
            SingleLinkNode q = this.Next;
            p.Next = null;

            while (q != null && q.Next != null)
            {
                SingleLinkNode r = q.Next;

                q.Next = p;
                p = q;
                q = r;
            }

            if (q != null && q.Next == null)
            {
                q.Next = p;
            }

            return q;
        }

        public SingleLinkNode Revert2()
        {
            SingleLinkNode p = this;

            if (p.Next != null)
            {
                SingleLinkNode pNext = p.Next;

                SingleLinkNode newHead = pNext.Revert2();

                pNext.Next = this;
                this.Next = null;

                return newHead;
            }

            return p;
        }


    }
}

