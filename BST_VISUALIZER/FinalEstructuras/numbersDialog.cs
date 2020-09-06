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
    public partial class numbersDialog : Form
    {
        private int ammountOfNumbers= 0;
        private int commaCounter = 0;
        private string[] numberArray;
        public BST_visualizer previousForm;
        public numbersDialog(BST_visualizer previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            previousForm.disableControls();
        }

        /*Creates(or not) a bst after making the necessary validations when the user clicks on the 'generate' button*/
        private void btnDone_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputNumbers.Text.ToString()))
            {
                lblInfo.Text = "You haven't entered any numbers yet.";
            }
            else if (commaAmmountVerifier() && !otherVerifiers() && numberAmmountVerifier())
            {
                BST_visualizer newBstVis = new BST_visualizer();
                lblInfo.Text = "Done!";
                newBstVis.createSearchTree(numberArray);
                newBstVis.changeTitleText();
                newBstVis.Show();
                previousForm.Hide();
                this.Close();
            }
            else
            {
                lblInfo.Text = "Please verify the data you are trying to submit.";
                ammountOfNumbers = 0;
                commaCounter = 0;
            }   
        }

        /*Verifies the ammount of commas that the user has inserted, also extracts the numbers and put them into a list*/
        private bool commaAmmountVerifier()
        {
            string text = inputNumbers.Text.Trim();
            char[] rawTxt = text.ToCharArray();
            string[] txtNumbersExtracted = text.Split(',');
            numberArray = txtNumbersExtracted;

            foreach(char c in rawTxt)
            {
                if (c.Equals(','))
                {
                    commaCounter++;
                }
            }
            foreach (string s in txtNumbersExtracted)
            {
                if (!s.Equals(""))
                {
                    ammountOfNumbers++;
                }
            }
            if (commaCounter == (ammountOfNumbers - 1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*Verifies the ammount of numbers that the user has inserted using the list of extracted numbers that we obtained via the previous method */
        private bool numberAmmountVerifier()
        {
            if (ammountOfNumbers < 10 && ammountOfNumbers > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*Makes sure at the user is not entering a non-number character and that each number cumply the parameters given by the program*/
        private bool otherVerifiers()
        {
            bool notCorrect = false;
            int number;
            foreach (string e in numberArray)
            {
                if (!int.TryParse(e, out number))
                {
                    notCorrect = true;
                }
                else if (int.Parse(e) > 100)
                {
                    notCorrect = true;
                }
                else if (int.Parse(e) <= 0)
                {
                    notCorrect = true;
                }
            }
            return notCorrect;
        }

        /*Creates a Random set of vertices that we can use to make a brand new bst*/
        private string[] generateRandomNodesList()
        {
            Random r = new Random();
            numberArray = new string[r.Next(1, 10)];

            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = (r.Next(1, 101)).ToString();
            }
            return numberArray;
        }

        /*Generates a new bst with the random vertices created by the previous method*/
        private void btnGenRan_Click(object sender, EventArgs e)
        {
            BST_visualizer newBstVis = new BST_visualizer();
            lblInfo.Text = "Done!";
            newBstVis.createSearchTree(generateRandomNodesList());
            newBstVis.Show();
            previousForm.Hide();
            this.Close();
        }

        /*Closes the current box and returns to the main form*/
        private void iconBtnBack_Click(object sender, EventArgs e)
        {
            previousForm.enableControls();
            this.Close();
        }

        /*Shows the user the program's parameters/instructions*/
        private void btn_instructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Instructions: \n1. Only nine numbers (vertices) total can be used to create the BST\n2. Each number must be separated by a comma\n3. Each number has to be within the range of 0-100");
        }
    }
}
