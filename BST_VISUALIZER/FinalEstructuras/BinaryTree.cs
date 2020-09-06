using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalEstructuras
{
    public class BinaryTree
    {
        BinaryNode root;
        BinaryNode parent;
        bool position;
        int ammount;
        int leafs;

        public BinaryTree(int data)
        {
            root = new BinaryNode(data);
            ammount = 1;
        }
        public BinaryTree()
        {
            root = null;
        }
        //***********************************************************************************
        public void add(int data)
        {
            if (root == null)
            {
                root = new BinaryNode(data);
            }
            else
            {
                if (search(data) != null)
                {
                    Console.WriteLine("Dude, the number is already in the tree");
                }
                else
                {
                    add(data, root);
                    ammount++;
                }

            }
        }
        private void add(int data, BinaryNode root)
        {
            if (data < root.getData())
            {
                //validacion por la izquierada
                insertion(data, root, 0);
            }
            else
            {
                //validacion por la derecha
                insertion(data, root, 1);
            }
        }
        private void insertion(int data, BinaryNode root, int whichChild)
        {
            if (whichChild == 0)
            {
                if (root.getLeftChild() == null)
                {
                    root.setLeftChild(new BinaryNode(data));
                }
                else
                {
                    add(data, root.getLeftChild());
                }
            }

            else if (whichChild == 1)
            {
                if (root.getRightChild() == null)
                {
                    root.setRightChild(new BinaryNode(data));
                }
                else
                {
                    add(data, root.getRightChild());
                }
            }

        }
        //***********************************************************************************
        public void inOrder()
        {
            inOrder(root);
        }
        private void inOrder(BinaryNode currentRoot)
        {
            if (currentRoot != null)
            {
                inOrder(currentRoot.getLeftChild());
                Console.WriteLine(currentRoot.getData() + " ");
                inOrder(currentRoot.getRightChild());
            }
             

        }
        public void preOrder()
        {
            if (root == null)
            {
                Console.WriteLine("My man, the tree is empty");
            }

            if (root.isLeaf())
            {
                Console.WriteLine("My man, the only existing node is the root: " + root.getData());
            }
            else
            {
                preOrder(root);
            }

        }
        private void preOrder(BinaryNode currentRoot)
        {
            if (currentRoot != null)
            {
                Console.WriteLine(currentRoot.getData() + " ");
                preOrder(currentRoot.getLeftChild());
                preOrder(currentRoot.getRightChild());
            }
        }
        public void posOrder()
        {
            posOrder(root);
        }
        private void posOrder(BinaryNode currentRoot)
        {
            if (currentRoot != null)
            {
                posOrder(currentRoot.getLeftChild());
                posOrder(currentRoot.getRightChild());
                Console.WriteLine(currentRoot.getData() + " ");

            }
        }
        //***********************************************************************************
        public BinaryNode search(int data)
        {
            return search(data, root);
        }
        private BinaryNode search(int data, BinaryNode currentRoot)
        {
            if (currentRoot == null)
            {
                return null;
            }
            if (data == currentRoot.getData())
            {
                return currentRoot;
            }
            parent = currentRoot;
            if (data < currentRoot.getData())
            {
                //if false the position is left
                position = true;
                return search(data, currentRoot.getLeftChild());
            }
            else
            {
                //if true the the position is right
                position = false;
                return search(data, currentRoot.getRightChild());
            }
        }
        //***********************************************************************************
        public void deleteNode(int data)
        {
            if (root == null)
            {
                Console.WriteLine("My friend, the tree is empty");
            }
            else
            {
                deleteNode(data, root);
                ammount--;
            }
        }
        private void deleteNode(int data, BinaryNode currentRoot)
        {
            BinaryNode tempNode = search(data);

            if (tempNode.isLeaf())
            {
                if (position)
                {
                    parent.setLeftChild(null);
                }
                else
                {
                    parent.setRightChild(null);
                }
            }
            else if (tempNode.hasOneChild())
            {
                if (tempNode.getchildPosition())
                {
                    parent.setLeftChild(tempNode.getLeftChild());
                }
                else
                {
                    parent.setRightChild(tempNode.getRightChild());
                }
            }
            else
            {
                BinaryNode min = getMinor(tempNode.getRightChild());
                deleteNode(min.getData());
                tempNode.setData(min.getData());
            }
        }
        //***********************************************************************************
        public BinaryNode getMinor(BinaryNode currentRoot)
        {
            if (currentRoot.getLeftChild() == null)
            {
                return currentRoot;
            }
            else
            {
                return getMinor(currentRoot.getLeftChild());
            }
        }
        //***********************************************************************************        
        public int showAmmount()
        {
            return ammount;
        }
        public void countLeafs()
        {
            countLeafs(root);
            Console.WriteLine(leafs);
        }
        private void countLeafs(BinaryNode currentRoot)
        {
            if (currentRoot != null)
            {
                countLeafs(currentRoot.getLeftChild());
                countLeafs(currentRoot.getRightChild());

                if (currentRoot.isLeaf())
                {
                    leafs++;
                }
            }
        }
    }
}
