using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _27ege
{
    class SegmentTree
    {
        public class Node
        {
            public int sum;
            public int left;
            public int right;
            public Node leftChild = null;
            public Node rightChild = null;
            public Node parent = null;

            public int SumSegment(int l, int r)
            {
                if (r < left || right < l)
                {
                    return 0;
                }
                if (l <= left &&  r >= right)
                {
                    return sum;
                }

                return leftChild.SumSegment(l, r) + rightChild.SumSegment(l, r);
            }
        }

        List<Node> leafs;
        Node root;
        public SegmentTree(int[] a)
        {
            var l = new List<Node>();
            for (int i = 0; i < a.Length; i++)
            {
                var node = new Node();
                node.sum = a[i];
                node.left = i;
                node.right = i;

                l.Add(node);
            }
            leafs = new List<Node>(l);

            while (l.Count != 1)
            {
                for (int i = 0; i < l.Count - 1; ++i)
                {
                    var node = new Node();
                    node.sum = l[i].sum + l[i + 1].sum;
                    node.left = l[i].left;
                    node.right = l[i + 1].right;
                    node.leftChild = l[i];
                    node.rightChild = l[i + 1];
                    node.leftChild.parent = node;
                    node.rightChild.parent = node;
                    l.RemoveAt(i);
                    l.RemoveAt(i);
                    l.Insert(i, node);
                }
            }

            root = l[0];
        }

        public void QueryModify(int index, int value)
        {
            var node = leafs[index];
            node.sum = value;
            while (node.parent != null)
            {
                node.sum = node.leftChild.sum + node.rightChild.sum;
                node = node.parent;
            }
            node.sum = node.leftChild.sum + node.rightChild.sum;
        }

        public int SumSegment(int index1, int index2)
        {
            return root.SumSegment(index1, index2); 
        }
    }
}
