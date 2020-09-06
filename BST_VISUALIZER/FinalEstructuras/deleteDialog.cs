using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace FinalEstructuras
{
    public partial class deleteDialog : Form
    {
        private ArrayList currentNodesList;
        private string[] nodesToDeleteList;
        public BST_visualizer previous;
        public deleteDialog(ArrayList currentNodesList, BST_visualizer previous)
        {
            InitializeComponent();
            this.currentNodesList = currentNodesList;
            this.previous = previous;
            previous.disableControls();
        }

        /*Verifies the given data and then deletes(or not) a set of specified nodes*/
        private void iconBtnDeleteNode_Click(object sender, EventArgs e)
        {
            BST_visualizer newBst = new BST_visualizer();
            if (verifyData())
            {
                newBst.createNewSearchTree(deleteAndUpdateCurrent(nodesToDeleteList));
                previous.Hide();
                newBst.Show();
                this.Close();
            }
        }

        /*Calls all the other verifications methods to make sure the data inserted by the user follows the program's parameters*/
        private bool verifyData()
        {
            bool returnValue = false;
            int commaCounter= 0;
            int numberCounter = 0;
            string text = inputNumDel.Text.Trim();
            char[] enteredNums = text.ToCharArray();
            string[] numbersToDelete = text.Split(',');

            if (foundNonNumber(numbersToDelete))
            {
                lblNote.Text = "Please make sure all entered values are numbers";
            }
            else if (numberNotInCurrentList(numbersToDelete))
            {
                lblNote.Text = "One or more nodes are not part of the current Binary \n Search Tree";
            }

            else
            {
                foreach (char c in enteredNums)
                {
                    if (c.Equals(','))
                    {
                        commaCounter++;
                    }
                }
                foreach (string s in numbersToDelete)
                {
                    if (!s.Equals(""))
                    {
                        numberCounter++;
                    }
                }

                if (commaCounter == (numberCounter - 1))
                {
                    nodesToDeleteList = numbersToDelete;
                    returnValue = true;
                }
                else
                {
                    returnValue = false;
                }
            }

            return returnValue;
        }

        /*Mkaes sure the user hasn't inserted a non-number character*/
        private bool foundNonNumber(string[] numsArr)
        {
            int resNum = 0;
            bool foundNonNumber = false;

            foreach (string s in numsArr)
            {
                if (!int.TryParse(s, out resNum))
                {
                    foundNonNumber = true;
                    break;
                }
            }
            return foundNonNumber;
        }

        /*Makes sure the number inserted is the value of one of the vertexes in the current bst*/
        private bool numberNotInCurrentList(string[] numsArr)
        {
            bool notInList = false;

            foreach (string s in numsArr)
            {
                if (!currentNodesList.Contains(int.Parse(s)))
                {
                    notInList = true;
                    break;
                }
            }
            return notInList;
        }

        /*Deletes the set of given nodes and returns a new set of numbers(vertices) which are the ones that remained in the previous bst */
        private ArrayList deleteAndUpdateCurrent(string[] arr)
        {
            foreach(string s in arr)
            {
               currentNodesList.Remove(int.Parse(s));
            }
            return currentNodesList;
        }

        /*Closes the delete dialog box and returns to the main form*/
        private void iconBtnBack_Click(object sender, EventArgs e)
        {
            previous.enableControls();
            this.Close();
        }
    }
}
