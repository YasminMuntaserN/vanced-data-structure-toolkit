using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    public class BinaryTree<T>
    {
        public BinaryTreeNode<T> Root { get; set; }


        public BinaryTree()
        {
            Root = null;
        }

        #region 1 : insert with Level-order insertion strategy
        public void Insert(T value)
        {
            var newNode = new BinaryTreeNode<T>(value);
            if (Root == null)
            {
                Root = newNode;
                return;
            }

            Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                if (current.left == null)
                {
                    current.left = newNode;
                    break;
                }
                else
                {
                    queue.Enqueue(current.left);
                }

                if (current.right == null)
                {
                    current.right = newNode;
                    break;
                }
                else
                {
                    queue.Enqueue(current.right);
                }
            }
        }
        #endregion


        #region Pre Order Traversal:
        public void PreOrderTraversal()
        {
            PreOrderTraversal(Root);
        }
        private void PreOrderTraversal(BinaryTreeNode<T> node)
        {
            if (node != null)
            {
                Console.Write(node.Value + "  ");
                PreOrderTraversal(node.left);
                PreOrderTraversal(node.right);
            }
        }
        #endregion


        #region Post Order Traversal:
        public void PostOrderTraversal()
        {
            PostOrderTraversal(Root);
        }
        private void PostOrderTraversal(BinaryTreeNode<T> node)
        {
            if (node != null)
            {
                PreOrderTraversal(node.left);
                PreOrderTraversal(node.right);
                Console.Write(node.Value + "  ");
            }
        }
        #endregion


        #region In Order Traversal:
        public void InOrderTraversal()
        {
            InOrderTraversal(Root);
        }
        private void InOrderTraversal(BinaryTreeNode<T> node)
        {
            if (node != null)
            {
                PreOrderTraversal(node.left);
                Console.Write(node.Value + "  ");
                PreOrderTraversal(node.right);
            }
        }
        #endregion


        #region Level Order Traversal:
        public void LevelOrderTraversal()
        {
            LevelOrderTraversal(Root);
        }
       
        private void LevelOrderTraversal(BinaryTreeNode<T> node)
        {
            Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                Console.Write(current.Value + "  ");


                if (current.left != null)
                {
                    queue.Enqueue(current.left);
                }
                if (current.right != null)
                {
                    queue.Enqueue(current.right);

                }
            }
        }

        public int getLevelsCount()
        {
            if (Root == null) return 0;

            int level = 0;
            Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                int nodesAtCurrentLevel = queue.Count;
                level++;

                while (nodesAtCurrentLevel > 0)
                {
                    var current = queue.Dequeue();

                    if (current.left != null)
                        queue.Enqueue(current.left);

                    if (current.right != null)
                        queue.Enqueue(current.right);

                    nodesAtCurrentLevel--;
                }
            }

            return level;
        }
      
        public List<T> getNodesInLevel(int level)
        {
            List<T> result = new List<T>();
            if (Root == null || level < 1) return result;

            Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
            queue.Enqueue(Root);
            int currentLevel = 1;

            while (queue.Count > 0)
            {
                int nodesAtCurrentLevel = queue.Count;

                if (currentLevel == level)
                {
                    foreach (var node in queue)
                    {
                        result.Add(node.Value); 
                    }
                    break;
                }

                while (nodesAtCurrentLevel > 0)
                {
                    var current = queue.Dequeue();

                    if (current.left != null) queue.Enqueue(current.left);
                    if (current.right != null) queue.Enqueue(current.right);

                    nodesAtCurrentLevel--;
                }

                currentLevel++; // Move to the next level
            }

            return result;
        }
        #endregion


        #region Print Tree:
        public void PrintTree()
        {
            PrintTree(Root, 0);
        }

        private void PrintTree(BinaryTreeNode<T> root, int space)
        {
            int COUNT = 10;  // Distance between levels to adjust the visual representation
            if (root == null)
                return;


            space += COUNT;
            PrintTree(root.right, space); // Print right subtree first, then root, and left subtree last


            Console.WriteLine();
            for (int i = COUNT; i < space; i++)
                Console.Write(" ");
            Console.WriteLine(root.Value); // Print the current node after space


            PrintTree(root.left, space); // Recur on the left child
        }
        #endregion
    }
}
