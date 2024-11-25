using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Tree
{
    public class Tree<T>
    {
        public TreeNode<T> Root { get; private set; }


        public Tree(T rootValue)
        {
            Root = new TreeNode<T>(rootValue);
        }


        public void PrintTreeElements(string indent = "")
        {
            PrintTree(this.Root  ,indent);
        }

        private void PrintTree<T>(TreeNode<T> node, string indent = "")
        {
            Console.WriteLine(indent + node.Value);
            foreach (var child in node.Children)
            {
                PrintTree(child, indent + "  ");
            }
        }

        public TreeNode<T> Find(T value)
        {
           return this.Root.Find(value);  
        }



    }

}
