using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace _27ege
{
    class SegmentTreeArray
    {
        public class Node
        {
            public int value;
            public int parent;
            public int leftChild;
            public int rightChild;
            public int left;
            public int right; //добавить
            public Node(int value = 0, int parent = 0, int leftChild = 0, int rightChild = 0)
            {
                this.value = value;
                this.parent = parent;
                this.leftChild = leftChild;
                this.rightChild = rightChild;
            }

            //public int SumSegment(int l, int r)
            //{
            //    if (r < left || right < l)
            //    {
            //        return 0;
            //    }
            //    if (l <= left && r >= right)
            //    {
            //        return sum;
            //    }

            //    return leftChild.SumSegment(l, r) + rightChild.SumSegment(l, r);
            //    }


            public override string ToString()
            {
                return string.Format("value: {0}, parent: {1}, left: {2}, right: {3}", value, parent, leftChild, rightChild);
            }
        }
        Node[] arr;
        public SegmentTreeArray(int[] startArray)
        {
            arr = new Node[startArray.Length * 2];

            for (int i = 0; i < startArray.Length; i++)
            {
                arr[i + 1] = new Node();
                arr[i + 1].value = startArray[i];
            }

            int r = 1;
            int w = startArray.Length + 1;
            Node temp = null;
            while (w != startArray.Length * 2)
            {
                int levelSize = w - r;
                if (levelSize % 2 == 1)
                {
                    if (temp == null)
                    {
                        temp = new Node(arr[w - 1].value, arr[w - 1].parent, arr[w - 1].leftChild, arr[w - 1].rightChild);
                        w--;
                        levelSize--;
                    }
                    else
                    {
                        arr[w] = new Node(temp.value, temp.parent, temp.leftChild, temp.rightChild);
                        temp = null;
                        w++;
                        levelSize++;
                    }
                }

                for (int i = 0; i < levelSize / 2; i++)
                {
                    arr[w] = new Node(arr[r].value + arr[r + 1].value, 0, r, r + 1);
                    arr[r].parent = w;
                    arr[r + 1].parent = w;
                    w++;
                    r += 2;
                }
            }

        }

        public override string ToString()
        {
            var s = "";
            for (int i = 1; i < arr.Length; i++)
            {
               s += arr[i].ToString() + "\n";
            }

            return s;
        }
    }

    class MyClass
    {
        //static void Main(string[] args)
        //{
        //    var node1 = new SegmentTreeArray.Node();
        //    var node2 = node1;
        //    node2.value = 10;
        //    int x = 50;
        //    int y = x;
        //    y++;
        //}
    }
}
