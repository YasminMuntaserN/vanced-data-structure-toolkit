using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    public class BinaryTreeNode<T>
    {
        public T Value { get; set; }
        public BinaryTreeNode<T> left { get; set; }
        public BinaryTreeNode<T> right { get; set; }

        public BinaryTreeNode(T value)
        {
            Value = value;
            left = null;
            right = null;
        }

    }
}
