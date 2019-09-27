using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonOnlineAssessment
{
    public class Tree
    {
        public List<Node> tree { get; set; }
        public void buildTree()
        {
            tree = inicializeTree();

            Node node = new Node(1);
            createLeftAndRightChildren(node);
            tree.Add(node);

            createLeftAndRightChildren(node);

            createLeftAndRightChildren(node);
            createLeftAndRightChildren(node);
            createLeftAndRightChildren(node);
            createLeftAndRightChildren(node);


        }

        private void createLeftAndRightChildren(Node node)
        {
            node.Left = new Node(node.Item + 1);
            node.Right = new Node(node.Left.Item + 1);
        }

        public List<Node> inicializeTree()
        {
            tree = new List<Node>();
            return tree;
        }
    }
}
