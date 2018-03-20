namespace WindowsFormsApplication1
{
    partial class createOrUpdate
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
            this.wherelb = new System.Windows.Forms.Label();
            this.wholb = new System.Windows.Forms.Label();
            this.namelb = new System.Windows.Forms.Label();
            this.whoBox = new System.Windows.Forms.ComboBox();
            this.whereBox = new System.Windows.Forms.ComboBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.createNewButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.nameStatic = new System.Windows.Forms.Label();
            this.errLb = new System.Windows.Forms.Label();
            this.quitButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wherelb
            // 
            this.wherelb.AutoSize = true;
            this.wherelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wherelb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.wherelb.Location = new System.Drawing.Point(8, 138);
            this.wherelb.Name = "wherelb";
            this.wherelb.Size = new System.Drawing.Size(64, 20);
            this.wherelb.TabIndex = 16;
            this.wherelb.Text = "Where :";
            // 
            // wholb
            // 
            this.wholb.AutoSize = true;
            this.wholb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wholb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.wholb.Location = new System.Drawing.Point(8, 81);
            this.wholb.Name = "wholb";
            this.wholb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.wholb.Size = new System.Drawing.Size(54, 20);
            this.wholb.TabIndex = 15;
            this.wholb.Text = "Who : ";
            // 
            // namelb
            // 
            this.namelb.AutoSize = true;
            this.namelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.namelb.Location = new System.Drawing.Point(6, 30);
            this.namelb.Name = "namelb";
            this.namelb.Size = new System.Drawing.Size(59, 20);
            this.namelb.TabIndex = 14;
            this.namelb.Text = "Name :";
            // 
            // whoBox
            // 
            this.whoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.whoBox.FormattingEnabled = true;
            this.whoBox.Items.AddRange(new object[] {
            "Clowns",
            "Jokers",
            "You"});
            this.whoBox.Location = new System.Drawing.Point(12, 103);
            this.whoBox.Name = "whoBox";
            this.whoBox.Size = new System.Drawing.Size(123, 21);
            this.whoBox.TabIndex = 13;
            // 
            // whereBox
            // 
            this.whereBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.whereBox.FormattingEnabled = true;
            this.whereBox.Items.AddRange(new object[] {
            "To the Left of Me",
            "To the Right",
            "Stuck in the Middle"});
            this.whereBox.Location = new System.Drawing.Point(12, 160);
            this.whereBox.Name = "whereBox";
            this.whereBox.Size = new System.Drawing.Size(123, 21);
            this.whereBox.TabIndex = 12;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(12, 53);
            this.nameBox.MaxLength = 15;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(102, 20);
            this.nameBox.TabIndex = 11;
            // 
            // createNewButton
            // 
            this.createNewButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createNewButton.Location = new System.Drawing.Point(12, 200);
            this.createNewButton.Name = "createNewButton";
            this.createNewButton.Size = new System.Drawing.Size(123, 25);
            this.createNewButton.TabIndex = 17;
            this.createNewButton.Text = "Create New";
            this.createNewButton.UseVisualStyleBackColor = true;
            this.createNewButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateButton
            // 
            this.updateButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateButton.Location = new System.Drawing.Point(12, 231);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(123, 25);
            this.updateButton.TabIndex = 18;
            this.updateButton.Text = "Update Existing";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // nameStatic
            // 
            this.nameStatic.AutoSize = true;
            this.nameStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.nameStatic.ForeColor = System.Drawing.Color.DodgerBlue;
            this.nameStatic.Location = new System.Drawing.Point(12, 9);
            this.nameStatic.Name = "nameStatic";
            this.nameStatic.Size = new System.Drawing.Size(0, 13);
            this.nameStatic.TabIndex = 19;
            // 
            // errLb
            // 
            this.errLb.AutoSize = true;
            this.errLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.errLb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.errLb.Location = new System.Drawing.Point(12, 269);
            this.errLb.Name = "errLb";
            this.errLb.Size = new System.Drawing.Size(0, 13);
            this.errLb.TabIndex = 20;
            // 
            // quitButton
            // 
            this.quitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.quitButton.Location = new System.Drawing.Point(15, 200);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(141, 37);
            this.quitButton.TabIndex = 21;
            this.quitButton.Text = "Exit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteButton.Location = new System.Drawing.Point(119, 12);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(63, 25);
            this.deleteButton.TabIndex = 22;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // createOrUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(194, 317);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.errLb);
            this.Controls.Add(this.nameStatic);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.createNewButton);
            this.Controls.Add(this.wherelb);
            this.Controls.Add(this.wholb);
            this.Controls.Add(this.namelb);
            this.Controls.Add(this.whoBox);
            this.Controls.Add(this.whereBox);
            this.Controls.Add(this.nameBox);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(210, 355);
            this.MinimumSize = new System.Drawing.Size(210, 355);
            this.Name = "createOrUpdate";
            this.Text = "createOrUpdate";
            this.Load += new System.EventHandler(this.createOrUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wherelb;
        private System.Windows.Forms.Label wholb;
        private System.Windows.Forms.Label namelb;
        private System.Windows.Forms.ComboBox whoBox;
        private System.Windows.Forms.ComboBox whereBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button createNewButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label nameStatic;
        private System.Windows.Forms.Label errLb;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button deleteButton;
    }
}