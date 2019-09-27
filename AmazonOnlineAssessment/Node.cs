using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonOnlineAssessment
{
    public class Node
    {
        int _item;
        Node _left, _right;
        public Node(int item)
        {
            Item = item;
            Left = Right = null;
        }

        public Node(int item, Node left, Node right)
        {
            Item = item;
            Left = left;
            Right = right;
        }

        public int Item { get => _item; set => _item = value; }
        public Node Right { get => _right; set => _right = value; }
        public Node Left { get => _left; set => _left = value; }
    }
}
