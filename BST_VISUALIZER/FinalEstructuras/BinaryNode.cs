using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalEstructuras
{
    public class BinaryNode
    {
        public int data;
        public BinaryNode leftChild;
        public BinaryNode rightChild;
        public int positionX;
        public int positionY;
        public bool childPosition;

        public BinaryNode(int data)
        {
            this.data = data;
            leftChild = rightChild = null;
        }

        public int getData()
        {
            return data;
        }

        public void setData(int data)
        {
            this.data = data;
        }

        public BinaryNode getLeftChild()
        {
            return leftChild;
        }

        public BinaryNode getRightChild()
        {
            return rightChild;
        }

        public void setLeftChild(BinaryNode newLC)
        {
            leftChild = newLC;
        }

        public void setRightChild(BinaryNode newLC)
        {
            rightChild = newLC;
        }

        public bool isLeaf()
        {
            return ((leftChild == null) && (rightChild == null)) ? true : false;
        }

        private bool verifiyChildAndPosition()
        {
            if (leftChild != null && rightChild == null)
            {
                childPosition = true;
                return true;
            }

            else if (leftChild == null && rightChild != null)
            {
                childPosition = false;
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool hasOneChild()
        {
            return verifiyChildAndPosition();
        }

        public bool getchildPosition()
        {
            return childPosition;
        }
        public int getPositionX()
        {
            return positionX;
        }
        public int getPositionY()
        {
            return positionY;
        }
        public void setPositionX(int newX)
        {
            positionX = newX;
        }
        public void setPositionY(int newY)
        {
            positionY = newY;
        }
    }
}
