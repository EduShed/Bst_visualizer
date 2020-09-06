using Bunifu.Framework.UI;
using Bunifu.Framework.Lib;
namespace FinalEstructuras
{
    partial class BST_visualizer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BST_visualizer));
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.iconBtnExit = new FontAwesome.Sharp.IconButton();
            this.txtTitle = new System.Windows.Forms.Label();
            this.icPicBox_currenBtnSelected = new FontAwesome.Sharp.IconPictureBox();
            this.panelMenu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.btnCreate = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icPicBox_currenBtnSelected)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.iconBtnExit);
            this.bunifuGradientPanel2.Controls.Add(this.txtTitle);
            this.bunifuGradientPanel2.Controls.Add(this.icPicBox_currenBtnSelected);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(217, 0);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(1195, 65);
            this.bunifuGradientPanel2.TabIndex = 4;
            // 
            // iconBtnExit
            // 
            this.iconBtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnExit.BackColor = System.Drawing.Color.Transparent;
            this.iconBtnExit.FlatAppearance.BorderSize = 0;
            this.iconBtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnExit.IconChar = FontAwesome.Sharp.IconChar.Paw;
            this.iconBtnExit.IconColor = System.Drawing.Color.White;
            this.iconBtnExit.IconSize = 30;
            this.iconBtnExit.Location = new System.Drawing.Point(1117, 12);
            this.iconBtnExit.Name = "iconBtnExit";
            this.iconBtnExit.Rotation = 0D;
            this.iconBtnExit.Size = new System.Drawing.Size(75, 43);
            this.iconBtnExit.TabIndex = 2;
            this.iconBtnExit.UseVisualStyleBackColor = false;
            this.iconBtnExit.Click += new System.EventHandler(this.iconBtnExit_Click);
            this.iconBtnExit.MouseEnter += new System.EventHandler(this.iconBtnExit_MouseEnter);
            this.iconBtnExit.MouseLeave += new System.EventHandler(this.iconBtnExit_MouseLeave);
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.BackColor = System.Drawing.Color.Transparent;
            this.txtTitle.Font = new System.Drawing.Font("Permanent Marker", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.Snow;
            this.txtTitle.Location = new System.Drawing.Point(71, 26);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(195, 24);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.Text = "Hit the create button!";
            // 
            // icPicBox_currenBtnSelected
            // 
            this.icPicBox_currenBtnSelected.BackColor = System.Drawing.Color.Transparent;
            this.icPicBox_currenBtnSelected.ForeColor = System.Drawing.Color.MediumPurple;
            this.icPicBox_currenBtnSelected.IconChar = FontAwesome.Sharp.IconChar.Sitemap;
            this.icPicBox_currenBtnSelected.IconColor = System.Drawing.Color.MediumPurple;
            this.icPicBox_currenBtnSelected.IconSize = 31;
            this.icPicBox_currenBtnSelected.Location = new System.Drawing.Point(33, 19);
            this.icPicBox_currenBtnSelected.Name = "icPicBox_currenBtnSelected";
            this.icPicBox_currenBtnSelected.Size = new System.Drawing.Size(32, 31);
            this.icPicBox_currenBtnSelected.TabIndex = 0;
            this.icPicBox_currenBtnSelected.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMenu.BackgroundImage")));
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.btnCreate);
            this.panelMenu.Controls.Add(this.btnDelete);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.panelMenu.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.panelMenu.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.panelMenu.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Quality = 10;
            this.panelMenu.Size = new System.Drawing.Size(217, 792);
            this.panelMenu.TabIndex = 3;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Transparent;
            this.panelLogo.Controls.Add(this.bunifuSeparator1);
            this.panelLogo.Controls.Add(this.Logo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(217, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 102);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(217, 43);
            this.bunifuSeparator1.TabIndex = 3;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // Logo
            // 
            this.Logo.Cursor = System.Windows.Forms.Cursors.No;
            this.Logo.Image = global::FinalEstructuras.Properties.Resources.Group_10;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(204, 126);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.No;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCreate.Font = new System.Drawing.Font("Permanent Marker", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.Snow;
            this.btnCreate.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnCreate.IconColor = System.Drawing.Color.Snow;
            this.btnCreate.IconSize = 20;
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.Location = new System.Drawing.Point(0, 146);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCreate.Rotation = 0D;
            this.btnCreate.Size = new System.Drawing.Size(220, 60);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create binary tree";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            this.btnCreate.MouseEnter += new System.EventHandler(this.btnCreate_MouseEnter);
            this.btnCreate.MouseLeave += new System.EventHandler(this.btnCreate_MouseLeave);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.No;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDelete.Font = new System.Drawing.Font("Permanent Marker", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Snow;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.Snow;
            this.btnDelete.IconSize = 20;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(0, 217);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDelete.Rotation = 0D;
            this.btnDelete.Size = new System.Drawing.Size(220, 60);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete a node";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.btnDelete_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            // 
            // BST_visualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1412, 792);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BST_visualizer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            //this.Paint += new System.Windows.Forms.PaintEventHandler(this.BST_visualizer_Paint);
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icPicBox_currenBtnSelected)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnCreate;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnDelete;
        private System.Windows.Forms.PictureBox Logo;
        private BunifuGradientPanel panelMenu;
        private BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.Label txtTitle;
        private FontAwesome.Sharp.IconPictureBox icPicBox_currenBtnSelected;
        private BunifuSeparator bunifuSeparator1;
        private FontAwesome.Sharp.IconButton iconBtnExit;
    }
}

