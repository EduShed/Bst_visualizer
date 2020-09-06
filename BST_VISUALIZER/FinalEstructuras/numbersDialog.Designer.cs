namespace FinalEstructuras
{
    partial class numbersDialog
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
            this.txtNumbers = new System.Windows.Forms.Label();
            this.inputNumbers = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnDone = new FontAwesome.Sharp.IconButton();
            this.btnGenRan = new FontAwesome.Sharp.IconButton();
            this.iconBtnBack = new FontAwesome.Sharp.IconButton();
            this.btn_instructions = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // txtNumbers
            // 
            this.txtNumbers.AutoSize = true;
            this.txtNumbers.Font = new System.Drawing.Font("Russo One", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumbers.ForeColor = System.Drawing.Color.White;
            this.txtNumbers.Location = new System.Drawing.Point(45, 9);
            this.txtNumbers.Name = "txtNumbers";
            this.txtNumbers.Size = new System.Drawing.Size(601, 21);
            this.txtNumbers.TabIndex = 0;
            this.txtNumbers.Text = "Please insert the nodes (numbers) your Binary search tree will have";
            this.txtNumbers.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // inputNumbers
            // 
            this.inputNumbers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.inputNumbers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputNumbers.Font = new System.Drawing.Font("Russo One", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNumbers.ForeColor = System.Drawing.Color.Gainsboro;
            this.inputNumbers.Location = new System.Drawing.Point(127, 43);
            this.inputNumbers.Name = "inputNumbers";
            this.inputNumbers.Size = new System.Drawing.Size(415, 28);
            this.inputNumbers.TabIndex = 1;
            this.inputNumbers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Russo One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(68, 86);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(561, 36);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Important: you can only enter 9 numbers max, each number separated by \r\na comma. " +
    "Plus, the values have to be within a range of 1 to 100.";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDone
            // 
            this.btnDone.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDone.Font = new System.Drawing.Font("Russo One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnDone.IconColor = System.Drawing.Color.White;
            this.btnDone.IconSize = 30;
            this.btnDone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDone.Location = new System.Drawing.Point(172, 143);
            this.btnDone.Name = "btnDone";
            this.btnDone.Rotation = 0D;
            this.btnDone.Size = new System.Drawing.Size(120, 36);
            this.btnDone.TabIndex = 2;
            this.btnDone.Text = "Generate";
            this.btnDone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnGenRan
            // 
            this.btnGenRan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGenRan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenRan.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGenRan.Font = new System.Drawing.Font("Russo One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenRan.ForeColor = System.Drawing.Color.White;
            this.btnGenRan.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnGenRan.IconColor = System.Drawing.Color.White;
            this.btnGenRan.IconSize = 30;
            this.btnGenRan.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGenRan.Location = new System.Drawing.Point(344, 143);
            this.btnGenRan.Name = "btnGenRan";
            this.btnGenRan.Rotation = 0D;
            this.btnGenRan.Size = new System.Drawing.Size(183, 36);
            this.btnGenRan.TabIndex = 2;
            this.btnGenRan.Text = "Generate random ";
            this.btnGenRan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenRan.UseVisualStyleBackColor = true;
            this.btnGenRan.Click += new System.EventHandler(this.btnGenRan_Click);
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
            this.iconBtnBack.Location = new System.Drawing.Point(652, 7);
            this.iconBtnBack.Name = "iconBtnBack";
            this.iconBtnBack.Rotation = 0D;
            this.iconBtnBack.Size = new System.Drawing.Size(32, 23);
            this.iconBtnBack.TabIndex = 4;
            this.iconBtnBack.UseVisualStyleBackColor = true;
            this.iconBtnBack.Click += new System.EventHandler(this.iconBtnBack_Click);
            // 
            // btn_instructions
            // 
            this.btn_instructions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_instructions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_instructions.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_instructions.Font = new System.Drawing.Font("Russo One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_instructions.ForeColor = System.Drawing.Color.White;
            this.btn_instructions.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.btn_instructions.IconColor = System.Drawing.Color.White;
            this.btn_instructions.IconSize = 30;
            this.btn_instructions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_instructions.Location = new System.Drawing.Point(298, 143);
            this.btn_instructions.Name = "btn_instructions";
            this.btn_instructions.Rotation = 0D;
            this.btn_instructions.Size = new System.Drawing.Size(40, 36);
            this.btn_instructions.TabIndex = 5;
            this.btn_instructions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_instructions.UseVisualStyleBackColor = true;
            this.btn_instructions.Click += new System.EventHandler(this.btn_instructions_Click);
            // 
            // numbersDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(693, 191);
            this.Controls.Add(this.btn_instructions);
            this.Controls.Add(this.iconBtnBack);
            this.Controls.Add(this.btnGenRan);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.inputNumbers);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtNumbers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "numbersDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "numbersDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNumbers;
        private System.Windows.Forms.TextBox inputNumbers;
        private FontAwesome.Sharp.IconButton btnDone;
        private System.Windows.Forms.Label lblInfo;
        private FontAwesome.Sharp.IconButton btnGenRan;
        private FontAwesome.Sharp.IconButton iconBtnBack;
        private FontAwesome.Sharp.IconButton btn_instructions;
    }
}