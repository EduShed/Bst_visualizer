namespace FinalEstructuras
{
    partial class deleteDialog
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
            this.inputNumDel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.iconBtnDeleteNode = new FontAwesome.Sharp.IconButton();
            this.iconBtnBack = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // inputNumDel
            // 
            this.inputNumDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.inputNumDel.Font = new System.Drawing.Font("Russo One", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNumDel.ForeColor = System.Drawing.Color.White;
            this.inputNumDel.Location = new System.Drawing.Point(70, 44);
            this.inputNumDel.Name = "inputNumDel";
            this.inputNumDel.Size = new System.Drawing.Size(387, 29);
            this.inputNumDel.TabIndex = 0;
            this.inputNumDel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Russo One", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please specify the node/s you want to delete";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Russo One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.White;
            this.lblNote.Location = new System.Drawing.Point(67, 85);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(379, 54);
            this.lblNote.TabIndex = 1;
            this.lblNote.Text = "Important: the nodes must be part of the already\r\ncreated Binary Search Tree. Eac" +
    "h number must\r\nbe separated by a comma.";
            this.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconBtnDeleteNode
            // 
            this.iconBtnDeleteNode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconBtnDeleteNode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnDeleteNode.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnDeleteNode.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconBtnDeleteNode.IconColor = System.Drawing.Color.White;
            this.iconBtnDeleteNode.IconSize = 30;
            this.iconBtnDeleteNode.Location = new System.Drawing.Point(225, 147);
            this.iconBtnDeleteNode.Name = "iconBtnDeleteNode";
            this.iconBtnDeleteNode.Rotation = 0D;
            this.iconBtnDeleteNode.Size = new System.Drawing.Size(80, 40);
            this.iconBtnDeleteNode.TabIndex = 2;
            this.iconBtnDeleteNode.UseVisualStyleBackColor = true;
            this.iconBtnDeleteNode.Click += new System.EventHandler(this.iconBtnDeleteNode_Click);
            // 
            // iconBtnBack
            // 
            this.iconBtnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconBtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnBack.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconBtnBack.IconChar = FontAwesome.Sharp.IconChar.Joomla;
            this.iconBtnBack.IconColor = System.Drawing.Color.White;
            this.iconBtnBack.IconSize = 16;
            this.iconBtnBack.Location = new System.Drawing.Point(500, 12);
            this.iconBtnBack.Name = "iconBtnBack";
            this.iconBtnBack.Rotation = 0D;
            this.iconBtnBack.Size = new System.Drawing.Size(32, 23);
            this.iconBtnBack.TabIndex = 3;
            this.iconBtnBack.UseVisualStyleBackColor = true;
            this.iconBtnBack.Click += new System.EventHandler(this.iconBtnBack_Click);
            // 
            // deleteDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(540, 199);
            this.Controls.Add(this.iconBtnBack);
            this.Controls.Add(this.iconBtnDeleteNode);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputNumDel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "deleteDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "deleteDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputNumDel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNote;
        private FontAwesome.Sharp.IconButton iconBtnDeleteNode;
        private FontAwesome.Sharp.IconButton iconBtnBack;
    }
}