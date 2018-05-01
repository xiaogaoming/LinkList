using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkListDuicheng
{
    public class DoubleLinkNode
    {
        public int Data { get; set; }

        public DoubleLinkNode Next { get; set; }

        public DoubleLinkNode Last { get; set; }

        public DoubleLinkNode(int data)
        {
            this.Data = data;
        }

        public bool IsDuicheng()
        {
            DoubleLinkNode first = this;
            DoubleLinkNode end = this.Last;

            while (first != end && first.Next != end)
            {
                if (first.Data == end.Data)
                {
                    first = first.Next;
                    end = end.Last;
                }
                else
                {
                    return false;
                }
            }

            if (first.Next == end)
            {
                return first.Data == end.Data;
            }

            return true;
        }
    }
}
