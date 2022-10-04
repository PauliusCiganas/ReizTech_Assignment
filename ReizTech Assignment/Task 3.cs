using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReizTech_Assignment
{
    public class Node
    {
        public int data;
        public Node left, right;

        public Node(int item)
        {
            data = item;
            left = right = null;
        }
    }
    
    public class BinaryTree
    {
        public Node root;

        public int maxDepth(Node node)
        {
            if (node == null)
                return 0;
            else
            {
                int leftDepth = maxDepth(node.left);
                int rightDepth = maxDepth(node.right);

                if (leftDepth > rightDepth)
                    return (leftDepth + 1);
                else
                    return (rightDepth + 1);
            }
        }
    }
}
