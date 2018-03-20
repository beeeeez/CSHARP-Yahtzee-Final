namespace WindowsFormsApplication1
{
    partial class leaderboards
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
            this.thedataGrid = new System.Windows.Forms.DataGridView();
            this.dateSearch = new System.Windows.Forms.DateTimePicker();
            this.userBox = new System.Windows.Forms.TextBox();
            this.scoreSearchbox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchAllButton = new System.Windows.Forms.Button();
            this.usernameBox = new System.Windows.Forms.Label();
            this.scoreBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.thedataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // thedataGrid
            // 
            this.thedataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.thedataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.thedataGrid.Enabled = false;
            this.thedataGrid.Location = new System.Drawing.Point(12, 12);
            this.thedataGrid.Name = "thedataGrid";
            this.thedataGrid.Size = new System.Drawing.Size(381, 388);
            this.thedataGrid.TabIndex = 0;
            // 
            // dateSearch
            // 
            this.dateSearch.Location = new System.Drawing.Point(37, 455);
            this.dateSearch.Name = "dateSearch";
            this.dateSearch.Size = new System.Drawing.Size(200, 20);
            this.dateSearch.TabIndex = 1;
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(37, 429);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(100, 20);
            this.userBox.TabIndex = 2;
            // 
            // scoreSearchbox
            // 
            this.scoreSearchbox.Location = new System.Drawing.Point(157, 429);
            this.scoreSearchbox.Name = "scoreSearchbox";
            this.scoreSearchbox.Size = new System.Drawing.Size(80, 20);
            this.scoreSearchbox.TabIndex = 3;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(280, 455);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(111, 20);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search For Scores";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchAllButton
            // 
            this.searchAllButton.Location = new System.Drawing.Point(280, 419);
            this.searchAllButton.Name = "searchAllButton";
            this.searchAllButton.Size = new System.Drawing.Size(111, 20);
            this.searchAllButton.TabIndex = 5;
            this.searchAllButton.Text = "Search All";
            this.searchAllButton.UseVisualStyleBackColor = true;
            this.searchAllButton.Click += new System.EventHandler(this.searchAllButton_Click);
            // 
            // usernameBox
            // 
            this.usernameBox.AutoSize = true;
            this.usernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.usernameBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usernameBox.Location = new System.Drawing.Point(34, 409);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(85, 17);
            this.usernameBox.TabIndex = 6;
            this.usernameBox.Text = "Username : ";
            // 
            // scoreBox
            // 
            this.scoreBox.AutoSize = true;
            this.scoreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.scoreBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scoreBox.Location = new System.Drawing.Point(154, 409);
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.Size = new System.Drawing.Size(53, 17);
            this.scoreBox.TabIndex = 7;
            this.scoreBox.Text = "Score :";
            // 
            // leaderboards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(404, 499);
            this.Controls.Add(this.scoreBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.searchAllButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.scoreSearchbox);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.dateSearch);
            this.Controls.Add(this.thedataGrid);
            this.Name = "leaderboards";
            this.Text = "leaderboards";
            this.Load += new System.EventHandler(this.leaderboards_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thedataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView thedataGrid;
        private System.Windows.Forms.DateTimePicker dateSearch;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.TextBox scoreSearchbox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button searchAllButton;
        private System.Windows.Forms.Label usernameBox;
        private System.Windows.Forms.Label scoreBox;
    }
}