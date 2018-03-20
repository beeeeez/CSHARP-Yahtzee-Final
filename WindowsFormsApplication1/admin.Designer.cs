namespace WindowsFormsApplication1
{
    partial class admin
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
            this.theData = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.searchAllButton = new System.Windows.Forms.Button();
            this.whereBox = new System.Windows.Forms.ComboBox();
            this.whoBox = new System.Windows.Forms.ComboBox();
            this.namelb = new System.Windows.Forms.Label();
            this.wholb = new System.Windows.Forms.Label();
            this.wherelb = new System.Windows.Forms.Label();
            this.buttonButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.theData)).BeginInit();
            this.SuspendLayout();
            // 
            // theData
            // 
            this.theData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.theData.Location = new System.Drawing.Point(12, 12);
            this.theData.Name = "theData";
            this.theData.Size = new System.Drawing.Size(379, 185);
            this.theData.TabIndex = 0;
            this.theData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.searchButton.Location = new System.Drawing.Point(12, 265);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(104, 31);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(14, 230);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(102, 20);
            this.nameBox.TabIndex = 2;
            // 
            // searchAllButton
            // 
            this.searchAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.searchAllButton.Location = new System.Drawing.Point(122, 265);
            this.searchAllButton.Name = "searchAllButton";
            this.searchAllButton.Size = new System.Drawing.Size(104, 31);
            this.searchAllButton.TabIndex = 4;
            this.searchAllButton.Text = "Search All";
            this.searchAllButton.UseVisualStyleBackColor = true;
            this.searchAllButton.Click += new System.EventHandler(this.searchAllButton_Click);
            // 
            // whereBox
            // 
            this.whereBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.whereBox.FormattingEnabled = true;
            this.whereBox.Items.AddRange(new object[] {
            "Any",
            "To the Left of Me",
            "To the Right",
            "Stuck in the Middle"});
            this.whereBox.Location = new System.Drawing.Point(261, 229);
            this.whereBox.Name = "whereBox";
            this.whereBox.Size = new System.Drawing.Size(123, 21);
            this.whereBox.TabIndex = 6;
            // 
            // whoBox
            // 
            this.whoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.whoBox.FormattingEnabled = true;
            this.whoBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.whoBox.Items.AddRange(new object[] {
            "Any",
            "Clowns",
            "Jokers",
            "You"});
            this.whoBox.Location = new System.Drawing.Point(127, 229);
            this.whoBox.Name = "whoBox";
            this.whoBox.Size = new System.Drawing.Size(123, 21);
            this.whoBox.TabIndex = 7;
            // 
            // namelb
            // 
            this.namelb.AutoSize = true;
            this.namelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.namelb.Location = new System.Drawing.Point(8, 207);
            this.namelb.Name = "namelb";
            this.namelb.Size = new System.Drawing.Size(59, 20);
            this.namelb.TabIndex = 8;
            this.namelb.Text = "Name :";
            // 
            // wholb
            // 
            this.wholb.AutoSize = true;
            this.wholb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wholb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.wholb.Location = new System.Drawing.Point(123, 207);
            this.wholb.Name = "wholb";
            this.wholb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.wholb.Size = new System.Drawing.Size(54, 20);
            this.wholb.TabIndex = 9;
            this.wholb.Text = "Who : ";
            // 
            // wherelb
            // 
            this.wherelb.AutoSize = true;
            this.wherelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wherelb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.wherelb.Location = new System.Drawing.Point(257, 207);
            this.wherelb.Name = "wherelb";
            this.wherelb.Size = new System.Drawing.Size(64, 20);
            this.wherelb.TabIndex = 10;
            this.wherelb.Text = "Where :";
            // 
            // buttonButton
            // 
            this.buttonButton.Location = new System.Drawing.Point(342, 265);
            this.buttonButton.Name = "buttonButton";
            this.buttonButton.Size = new System.Drawing.Size(49, 31);
            this.buttonButton.TabIndex = 12;
            this.buttonButton.Text = ">:L";
            this.buttonButton.UseVisualStyleBackColor = true;
            this.buttonButton.Click += new System.EventHandler(this.buttonButton_Click);
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.createButton.Location = new System.Drawing.Point(232, 265);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(97, 31);
            this.createButton.TabIndex = 13;
            this.createButton.Text = "Create New";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(403, 309);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.buttonButton);
            this.Controls.Add(this.wherelb);
            this.Controls.Add(this.wholb);
            this.Controls.Add(this.namelb);
            this.Controls.Add(this.whoBox);
            this.Controls.Add(this.whereBox);
            this.Controls.Add(this.searchAllButton);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.theData);
            this.Name = "admin";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.theData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView theData;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button searchAllButton;
        private System.Windows.Forms.ComboBox whereBox;
        private System.Windows.Forms.ComboBox whoBox;
        private System.Windows.Forms.Label namelb;
        private System.Windows.Forms.Label wholb;
        private System.Windows.Forms.Label wherelb;
        private System.Windows.Forms.Button buttonButton;
        private System.Windows.Forms.Button createButton;
    }
}