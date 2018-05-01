using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkListDuicheng
{
    public class TreeNode
    {
        public int Data { get; set; }

        public TreeNode Left { get; set; }

        public TreeNode Right { get; set; }

        public DoubleLinkNode ConvertTreeToLinkList()
        {
            DoubleLinkNode leftHead = null;
            DoubleLinkNode rightHead = null;

            if (this.Left != null || this.Right != null)
            {
                DoubleLinkNode current = new DoubleLinkNode(this.Data);

                if (this.Left != null)
                {
                    leftHead = this.Left.ConvertTreeToLinkList();
                }

                if (this.Right != null)
                {
                    rightHead = this.Right.ConvertTreeToLinkList();
                }

                if (leftHead != null)
                {
                    DoubleLinkNode p = leftHead;

                    while (p.Next != null)
                    {
                        p = p.Next;
                    }

                    p.Next = current;
                    current.Last = p;
                }
                else
                {
                    leftHead = current;
                }

                if (rightHead != null)
                {
                    current.Next = rightHead;
                    rightHead.Last = current;
                }

                return leftHead;

            }
            else
            {
                DoubleLinkNode node = new DoubleLinkNode(this.Data);
                node.Next = null;
                node.Last = null;

                return node;
            }

        }
    }
}
