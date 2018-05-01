using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkListSort
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkNode linkNode = new SingleLinkNode(3);
            linkNode.Insert(8);
            linkNode.Insert(6);
            linkNode.Insert(5);
            linkNode.Insert(10);
            SingleLinkNode result = linkNode.Insert(2);

            // 2-3-5-6-8-10

            //SingleLinkNode jiHead = null;
            //SingleLinkNode ouHead = null;

            //result.Split(out jiHead, out ouHead);

            //SingleLinkNode revertLink = result.Revert();
            SingleLinkNode revertLink = result.Revert2();

        }
    }
}
