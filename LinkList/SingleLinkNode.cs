using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    public class SingleLinkNode<T>
    {
        public T Data { get; set; }

        public SingleLinkNode<T> Next { get; set; }

        public SingleLinkNode()
        { }

        public SingleLinkNode(T data)
        {
            this.Data = data;
        }

        public SingleLinkNode(T data, SingleLinkNode<T> next)
        {
            this.Data = data;
            this.Next = next;
        }
    }
}
