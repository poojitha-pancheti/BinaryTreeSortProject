using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeSort
{
    class TreeNode
    {
        public TreeNode lchild;
        public char info;
        public TreeNode rchild;
        public TreeNode(char ch)
        {
            info = ch;
            lchild = null;
            rchild = null;
        }
    }
}
