using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombineSingleLinkList
{
    public class SingleLinkNode
    {
        public int Data { get; set; }

        public SingleLinkNode Next { get; set; }

        public SingleLinkNode(int data)
        {
            this.Data = data;
        }

        public void InsertAfter(int data)
        {
            SingleLinkNode p = this;

            while (p.Next != null)
            {
                p = p.Next;
            }

            SingleLinkNode newNode = new SingleLinkNode(data);

            p.Next = newNode;
        }

        public SingleLinkNode Combine(SingleLinkNode secondLinkList)
        {
            if (secondLinkList == null) return this;

            SingleLinkNode first = this;
            SingleLinkNode second = secondLinkList;

            SingleLinkNode newHead = null;

            // 第一个链表的第一个元素大，我们取第二个链表的第一个元素为头
            if (first.Data > second.Data)
            {
                newHead = second;
                second = second.Next;
            }
            // 第二个链表的第一个元素大，我们取第一个链表的第一个元素为头
            else
            {
                newHead = first;
                first = first.Next;
            }

            SingleLinkNode temp = newHead;

            while (first != null && second != null)
            {
                if (first.Data > second.Data)
                {
                    //调整newhead所在的链表，将second挂上去
                    temp.Next = second;
                    second = second.Next;
                }
                else
                {
                    //调整newhead所在的链表，将first挂上去
                    temp.Next = first;
                    first = first.Next;
                }

                temp = temp.Next;
            }

            //第一个链表没有结束，第二个链表已经结束了
            if (first != null)
            {
                temp.Next = first;
            }

            if (second != null)
            {
                temp.Next = second;
            }

            return newHead;
        }
    }
}
