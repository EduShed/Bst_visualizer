using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Collections;
using System.Threading;

namespace FinalEstructuras
{
    public partial class BST_visualizer : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private ArrayList dataList = new ArrayList();
        BinaryNode root = null;
        BinaryNode mainRoot;
        BinaryNode parent = null;
        bool position;
        public BST_visualizer()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            btnCreate.Enabled = true;
            btnDelete.Enabled = true;
            Logo.Enabled = true;
        }

        /*Allows the user to add a vertex to to the bst*/
        public void add(int data)
        {
            if (root == null)
            {
                root = new BinaryNode(data);
                root.setPositionX(1000);
                root.setPositionY(80);
                mainRoot = root;
                graphNode(root.getPositionX(), root.getPositionY(), data, 0);
            }
            else
            {
                if (search(data) != null)
                {
                    txtTitle.Text= ("No duplicate vertex allowed!");
                }
                else
                {
                    add(data, root);
                }

            }
        }
        private void add(int data, BinaryNode root)
        {
            if (data < root.getData())
            {
                //validacion por la izquierda
                insertion(data, root, 0);
            }
            else
            {
                //validacion por la derecha
                insertion(data, root, 1);
            }
        }
        /***********************************************/

        /*Finds the position at which the vertex shoud be inserted and inserts it*/
        private void insertion(int data, BinaryNode root, int whichChild)
        {
            int line = 0;
            if (whichChild == 0)
            {
                if (root.getLeftChild() == null)
                {
                    root.setLeftChild(new BinaryNode(data));

                    if (root != mainRoot)
                    {
                        root.getLeftChild().setPositionX(root.getPositionX() - 100);
                        root.getLeftChild().setPositionY(root.getPositionY() + 100);
                        line = 1;
                    }
                    else 
                    {
                        root.getLeftChild().setPositionX(root.getPositionX() - 330);
                        root.getLeftChild().setPositionY(root.getPositionY() + 100);
                        line = 3;
                    }
                    graphNode(root.getLeftChild().getPositionX(), root.getLeftChild().getPositionY(), data, line);
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

                    if (root != mainRoot)
                    {
                        root.getRightChild().setPositionX(root.getPositionX() + 100);
                        root.getRightChild().setPositionY(root.getPositionY() + 100);
                        line = 2;
                    }
                    else
                    {
                        root.getRightChild().setPositionX(root.getPositionX() + 330);
                        root.getRightChild().setPositionY(root.getPositionY() + 100);
                        line = 4;
                    }
                    
                    graphNode(root.getRightChild().getPositionX(), root.getRightChild().getPositionY(), data, line);
                }
                else
                {
                    add(data, root.getRightChild());
                }
            }

        }

        /*Searchs for the empty spot in which the vertex the user is adding should be placed*/
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
        /******************************************************************/

        /*Draws the vertex on screen given it's information(position, data and the line that connects to parent vertex in case the node is a child)*/
        private void graphNode(int x, int y, int data, int childLine)
        {
            
            if (childLine == 1)
            {
                var lbl = new Label()
                {
                    Location = new Point(x + 10, y + 15),
                    Text = data + " ",
                    Size = new Size(40, 20),
                    Padding = new Padding(0),
                    Image = Properties.Resources.Node,
                    BackColor = Color.Transparent,
                    ForeColor = Color.White,
                    Font = new Font("Russo One", 10),
                };

                var node = new PictureBox()
                {
                    Location = new Point(x, y),
                    Size = new Size(50, 50),
                    Padding = new Padding(2),
                    BackColor = Color.Transparent,
                    Image = Properties.Resources.Node,
                    SizeMode = PictureBoxSizeMode.StretchImage,

                };

                var leftLine = new PictureBox()
                {
                    Location = new Point(x + 30, y - 77),
                    Size = new Size(100, 100),
                    Padding = new Padding(2),
                    BackColor = Color.Transparent,
                    Image = Properties.Resources.childLeft,
                    SizeMode = PictureBoxSizeMode.StretchImage,

                };
                this.Controls.Add(lbl);
                this.Controls.Add(node);
                this.Controls.Add(leftLine);
            }
            else if (childLine == 2)
            {
                var lbl = new Label()
                {
                    Location = new Point(x + 10, y + 15),
                    Text = data + " ",
                    Size = new Size(40, 20),
                    Padding = new Padding(0),
                    Image = Properties.Resources.Node,
                    BackColor = Color.Transparent,
                    ForeColor = Color.White,
                    Font = new Font("Russo One", 10),
                };

                var node = new PictureBox()
                {
                    Location = new Point(x, y),
                    Size = new Size(50, 50),
                    Padding = new Padding(2),
                    BackColor = Color.Transparent,
                    Image = Properties.Resources.Node,
                    SizeMode = PictureBoxSizeMode.StretchImage,

                };

                var rightLine = new PictureBox()
                {
                    Location = new Point(x - 80, y - 85),
                    Size = new Size(100, 100),
                    Padding = new Padding(2),
                    BackColor = Color.Transparent,
                    Image = Properties.Resources.childRight,
                    SizeMode = PictureBoxSizeMode.StretchImage,

                };
                this.Controls.Add(lbl);
                this.Controls.Add(node);
                this.Controls.Add(rightLine);
            }
            else if (childLine == 3)
            {
                var lbl = new Label()
                {
                    Location = new Point(x + 10, y + 15),
                    Text = data + " ",
                    Size = new Size(40, 20),
                    Padding = new Padding(0),
                    Image = Properties.Resources.Node,
                    BackColor = Color.Transparent,
                    ForeColor = Color.White,
                    Font = new Font("Russo One", 10),
                };

                var node = new PictureBox()
                {
                    Location = new Point(x, y),
                    Size = new Size(50, 50),
                    Padding = new Padding(2),
                    BackColor = Color.Transparent,
                    Image = Properties.Resources.Node,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                };
                var leftLine = new PictureBox()
                {
                    Location = new Point(x + 46 , y - 75),
                    Size = new Size(330, 100),
                    Padding = new Padding(0),
                    BackColor = Color.Transparent,
                    Image = Properties.Resources.rtLeft,
                    SizeMode = PictureBoxSizeMode.Normal,

                };
                this.Controls.Add(lbl);
                this.Controls.Add(node);
                this.Controls.Add(leftLine);
            }
            else if (childLine == 4)
            {
                var lbl = new Label()
                {
                    Location = new Point(x + 10, y + 15),
                    Text = data + " ",
                    Size = new Size(40, 20),
                    Padding = new Padding(0),
                    Image = Properties.Resources.Node,
                    BackColor = Color.Transparent,
                    ForeColor = Color.White,
                    Font = new Font("Russo One", 10),
                };

                var node = new PictureBox()
                {
                    Location = new Point(x, y),
                    Size = new Size(50, 50),
                    Padding = new Padding(2),
                    BackColor = Color.Transparent,
                    Image = Properties.Resources.Node,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                };
                var rightLine = new PictureBox()
                {
                    Location = new Point(x - 280, y - 76),
                    Size = new Size(340, 100),
                    Padding = new Padding(2),
                    BackColor = Color.Transparent,
                    Image = Properties.Resources.rtRight,
                    SizeMode = PictureBoxSizeMode.Normal,

                };
                this.Controls.Add(lbl);
                this.Controls.Add(node);
                this.Controls.Add(rightLine);
            }
            else 
            {
                var lbl = new Label()
                {
                    Location = new Point(x + 10, y + 15),
                    Text = data + " ",
                    Size = new Size(40, 20),
                    Padding = new Padding(0),
                    Image = Properties.Resources.Node,
                    BackColor = Color.Transparent,
                    ForeColor = Color.White,
                    Font = new Font("Russo One", 10),
                };

                var node = new PictureBox()
                {
                    Location = new Point(x, y),
                    Size = new Size(50, 50),
                    Padding = new Padding(2),
                    BackColor = Color.Transparent,
                    Image = Properties.Resources.Node,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                };
                this.Controls.Add(lbl);
                this.Controls.Add(node);
            }
            
            
        }

        /*Creates our bst given a set of numbers inside an array*/
        public void createSearchTree(string[] numbers)
        {
            dataList.Clear();
            foreach (string e in numbers)
            {
                dataList.Add(int.Parse(e));
            }

            for (int i = 0; i < dataList.Count; i++)
            {
                add((int)dataList[i]);
            }
        }

        /*Creates a bst from scratch given an array of numbers*/
        public void createNewSearchTree(ArrayList newNodes)
        {
            dataList = newNodes;
            for (int i = 0; i < dataList.Count; i++)
            {
                add((int)dataList[i]);
            }
        }

        /*The folowwing methods are on click listeners for various views/elements*/
        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteDialog delDiag = new deleteDialog(dataList, this);
            activeButton(sender, storeRgbColours.color2);
            delDiag.Show();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            numbersDialog nd = new numbersDialog(this);
            activeButton(sender, storeRgbColours.color1);
            nd.Show();
        }
        private void Logo_Click(object sender, EventArgs e)
        {
            reset();
        }
        private void iconBtnExit_Click(object sender, EventArgs e)
        {
            thankYouPrompt byee = new thankYouPrompt();
            byee.Show();
        }
        /*************************************************************************/

        /*Resets the form completely*/
        private void reset()
        {
            Application.Restart();
        }

        /*Changes the title text*/
        public void changeTitleText()
        {
            txtTitle.Text = "Check it out!";
        }

        /*Disable the controls of the form so that the user cannot acces them while creating or deleting vertices*/
        public void disableControls()
        {
            foreach (Control c in this.Controls)
            {
                c.Enabled = false;
            }
        }

        /*Re enables the controls when the user finishes*/
        public void enableControls()
        {
            foreach (Control c in this.Controls)
            {
                c.Enabled = true;
            }
        }

        /*The following set of methods describe the reaction of certain elements when interacting with mouse*/
        private void btnCreate_MouseEnter(object sender, EventArgs e)
        {
            btnCreate.BackColor = SystemColors.ButtonHighlight;
        }
        private void btnCreate_MouseLeave(object sender, EventArgs e)
        {
            btnCreate.BackColor = Color.Transparent;
        }
        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.BackColor = SystemColors.ButtonHighlight;
        }
        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.Transparent;
        }
        private void iconBtnExit_MouseEnter(object sender, EventArgs e)
        {
            iconBtnExit.BackColor = SystemColors.ButtonHighlight;
        }
        private void iconBtnExit_MouseLeave(object sender, EventArgs e)
        {
            iconBtnExit.BackColor = Color.Transparent;
        }
        /****************************************************************************/

        /*Defines the look of a button when its active(the user has clicked on it)*/
        private void activeButton(Object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                disableButtonHighlighting();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                icPicBox_currenBtnSelected.IconChar = currentBtn.IconChar;
                icPicBox_currenBtnSelected.IconColor = color;
                txtTitle.Text = currentBtn.Text;
            }
        }

        /*Resetes the button's look to default when user clicks on a new button*/
        private void disableButtonHighlighting()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.Transparent;
                currentBtn.ForeColor = Color.Snow;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Snow;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        /*Set of Rgb Colours that we use for our button animations*/
        private struct storeRgbColours
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
     
        
    }
}
