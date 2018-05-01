using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossLinkList
{
    public class SingleLinkNode
    {
        public int Data { get; set; }

        public SingleLinkNode Next { get; set; }

        public SingleLinkNode(int data)
        {
            this.Data = data;
        }

        public SingleLinkNode FindCrossNode(SingleLinkNode secondLinkNode)
        {
            if (secondLinkNode != null)
            {
                int currentLength = 0;
                int secondLength = 0;

                SingleLinkNode first = this;
                SingleLinkNode second = secondLinkNode;

                while (first != null)
                {
                    currentLength++;
                    first = first.Next;
                }

                while (second != null)
                {
                    secondLength++;
                    second = second.Next;
                }

                first = this;
                second = secondLinkNode;

                // 当前的链表比较长，我们先把差值的步数先走掉
                // 然后齐步走
                if (currentLength > secondLength)
                {
                    int gap = currentLength - secondLength;

                    while (gap > 0)
                    {
                        first = first.Next;
                        gap--;
                    }

                }
                // 先走secondlinknode， 然后齐步走
                else
                {
                    int gap = secondLength - currentLength;

                    while (gap > 0)
                    {
                        second = second.Next;
                        gap--;
                    }
                }

                while (first != null && second != null && first != second)
                {
                    first = first.Next;
                    second = second.Next;
                }

                if (first == second)
                    return first;
            }

            return null;
        }
    }
}
