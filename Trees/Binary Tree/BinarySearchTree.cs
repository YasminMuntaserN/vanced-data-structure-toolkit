using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Binary_Tree
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public BinaryTree<T> binaryTree;
        public BinarySearchTree()
        {
            binaryTree = new BinaryTree<T>(); ;   
        }

        /*  public void Insert(T value)
          {
              var newNode = new BinaryTreeNode<T>(value);
              if (binaryTree.Root == null)
              {
                  binaryTree.Root = newNode;
                  return;
              }

              Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
              queue.Enqueue(binaryTree.Root);

              while (queue.Count > 0)
              {
                  var current = queue.Dequeue();


                  if (value.CompareTo(current.Value) < 0)
                  {
                      if (current.left == null)
                      {
                          current.left = newNode;
                          break;
                      }
                      else
                          queue.Enqueue(current.left);

                  }
                  if (value.CompareTo(current.Value) > 0)
                  {
                      if (current.right ==null)
                      {
                      current.right = newNode;
                          break;

                      }
                      else
                      queue.Enqueue(current.right);
                  }
              }
          }
       */

        public void Insert(T value)
        {
            binaryTree.Root = Insert(binaryTree.Root, value);
        }

        private BinaryTreeNode<T> Insert(BinaryTreeNode<T> node, T value)
        {
            if (node == null)
            {
                return new BinaryTreeNode<T>(value);
            }
            else if (value.CompareTo(node.Value) < 0)
            {
                node.left = Insert(node.left, value);
            }
            else if (value.CompareTo(node.Value) > 0)
            {
                node.right = Insert(node.right, value);
            }
            return node;
        }

        public bool Search(T value)
        {
            return Search(binaryTree.Root, value) != null;
        }
        private BinaryTreeNode<T> Search(BinaryTreeNode<T> node, T value)
        {
            if (node == null || node.Value.Equals(value))
            {
                return node;
            }
            else if (value.CompareTo(node.Value) < 0)
            {
                return Search(node.left, value);
            }
            else
            {
                return Search(node.right, value);
            }
        }
        public void PrintTree()
        {
            binaryTree.PrintTree();  
        }

    }
}
