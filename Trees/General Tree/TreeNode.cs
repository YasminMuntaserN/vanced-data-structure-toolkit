using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Tree
{
    public class TreeNode<T>
    {
        public T Value { get; set; }

        // we make the children as a list because each node my have one or more Node as child
        public List<TreeNode<T>> Children { get; set; }


        public TreeNode(T value)
        {
            this.Value = value;
            this.Children = new List<TreeNode<T>>();
        }


        // Method to add a child node to the node
        public void AddChild(TreeNode<T> child)
        {
            Children.Add(child);
        }

        public TreeNode<T> Find(T value)
        {
            if (Value.Equals(value))
                return this;

            foreach (var child in Children)
            {
                var result = child.Find(value);
                if (result != null)
                    return result;
            }

            return null;
        }
    }
}
