using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVL_Tree
{
    public class AVLTree
    {
        private AVLNode root;

        #region Insert:
        public void Insert(int value)
        {
            root = Insert(root, value);
        }

        private AVLNode Insert(AVLNode node ,int value) 
        {
            if(node == null)
            {
                return new AVLNode(value);
            }
            if (value >node.Value)
            {
               node.Right = Insert(node.Right, value);
            }
            else if (value <node.Value)
            {
                node.Left = Insert(node.Left, value);
            }

            UpdatedHeight(node);

            return Balance(node);   
        }
        private int Height(AVLNode node)
        {
            return node != null ? node.Height : 0;
        }

        public void UpdatedHeight(AVLNode node) 
        {
            node.Height= 1 + Math.Max(Height(node.Left), Height( node.Right));
        }

        private int GetBF(AVLNode node)
        {
            return (node != null) ? Height(node.Left) - Height(node.Right) : 0;
        }
        
        private AVLNode Balance(AVLNode node)
        {
            int BF = GetBF(node);

            // RR - Right Rotation Case : Parent BF=-2 , Child BF for right child = -1 or 0
            if (BF < -1 && GetBF(node.Right) <= 0)
                return LeftRotate(node);

            // LL Case: Parent BF=+2 , Child BF for left child = +1 or 0
            if (BF > 1 && GetBF(node.Left) >= 0)
                return RightRotate(node);


            // LR - Left Rotation Case : Parent BF=+2 , Child BF for right child = -1 
            if (BF > 1 && GetBF(node.Left) < 0)
            {
                node.Left = LeftRotate(node.Left);
                return RightRotate(node);
            }

            // RL - Right-Left Rotation Case : Parent BF=-2 , Child BF for right child = +1
            if (BF < -1 && GetBF(node.Right) > 0)
            {
                node.Right = RightRotate(node.Right);
                return LeftRotate(node);
            }


            return node;
        }

        private AVLNode LeftRotate(AVLNode orginalRoot) 
        {
            AVLNode newRoot = orginalRoot.Right;
            AVLNode orginalRootLeftChild = newRoot.Left;
            newRoot.Left = orginalRoot;
            orginalRoot.Right = orginalRootLeftChild;

            UpdatedHeight(orginalRoot);
            UpdatedHeight(newRoot);

            return  newRoot;
            ;

        }

        private AVLNode RightRotate(AVLNode orginalRoot)
        {
            AVLNode newRoot = orginalRoot.Left;
            AVLNode orginalRootRightChild = newRoot.Right;
            newRoot.Right = orginalRoot;
            orginalRoot.Left = orginalRootRightChild;

            UpdatedHeight(orginalRoot);
            UpdatedHeight(newRoot);

            return newRoot;

        }
        #endregion

        #region Delete :
        public void Delete(int value)
        {
            root = DeleteNode(root, value);
        }

        private AVLNode DeleteNode(AVLNode node, int value)
        {
            if (node == null)
            {
                return node;
            }

            if (value < node.Value)
            {
                node.Left = DeleteNode(node.Left, value);
            }
            else if (value > node.Value)
            {
                node.Right = DeleteNode(node.Right, value);
            }
            else
            {
                //If the node to be deleted has one child or no child,
                if (node.Left == null)
                {
                    return node.Right;
                }
                else if (node.Right == null)
                {
                    return node.Left;
                }

                //if the node to be deleted has two children,
                //find the smallest node in the right subtree (inorder successor)
                AVLNode temp = MinValueNode(node.Right);

                node.Value = temp.Value;

                node.Right = DeleteNode(node.Right, temp.Value);
            }

            UpdatedHeight(node);

            return Balance(node);
        }

        private AVLNode MinValueNode(AVLNode node)
        {
            AVLNode current = node;
            while (current.Left != null)
            {
                current = current.Left;
            }
            return current;
        }

        #endregion

        #region  Search in AVL Tree:
        public bool Search(int value)
        {
            return Search(root, value) != null;
        }

        private AVLNode Search(AVLNode node, int value)
        {
            
            if (node == null ||node.Value == value )
            {
                return node;
            }
            if (value > node.Value)
            {
               return Search(node.Right, value);
            }
            else if (value < node.Value)
            {
                return Search(node.Left, value);
            }

            return null;
        }
        #endregion

        #region Print Tree:
        public void PrintTree()
        {
            PrintTree(root, 0);
        }

        private void PrintTree(AVLNode root, int space)
        {
            int COUNT = 10; 
            if (root == null)
                return;


            space += COUNT;
            PrintTree(root.Right, space); 


            Console.WriteLine();
            for (int i = COUNT; i < space; i++)
                Console.Write(" ");
            Console.WriteLine(root.Value);


            PrintTree(root.Left, space);
        }
        #endregion


    }

}
