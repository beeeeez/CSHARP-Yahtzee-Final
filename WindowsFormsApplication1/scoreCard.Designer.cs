namespace WindowsFormsApplication1
{
    partial class scoreCard
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
            this.lowerGrid = new System.Windows.Forms.DataGridView();
            this.upperGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dicePic5 = new System.Windows.Forms.PictureBox();
            this.dicePic4 = new System.Windows.Forms.PictureBox();
            this.dicePic3 = new System.Windows.Forms.PictureBox();
            this.dicePic2 = new System.Windows.Forms.PictureBox();
            this.dicePic1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lowerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicePic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicePic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicePic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicePic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicePic1)).BeginInit();
            this.SuspendLayout();
            // 
            // lowerGrid
            // 
            this.lowerGrid.AllowUserToDeleteRows = false;
            this.lowerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lowerGrid.Location = new System.Drawing.Point(12, 157);
            this.lowerGrid.Name = "lowerGrid";
            this.lowerGrid.ReadOnly = true;
            this.lowerGrid.RowHeadersWidth = 5;
            this.lowerGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lowerGrid.Size = new System.Drawing.Size(285, 269);
            this.lowerGrid.TabIndex = 8;
            this.lowerGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lowerGrid_CellContentClick);
            // 
            // upperGrid
            // 
            this.upperGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.upperGrid.Location = new System.Drawing.Point(319, 157);
            this.upperGrid.Name = "upperGrid";
            this.upperGrid.RowHeadersWidth = 5;
            this.upperGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.upperGrid.Size = new System.Drawing.Size(285, 269);
            this.upperGrid.TabIndex = 9;
            this.upperGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.upperGrid_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 608);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dicePic5
            // 
            this.dicePic5.Image = global::WindowsFormsApplication1.Properties.Resources._1;
            this.dicePic5.Location = new System.Drawing.Point(492, 12);
            this.dicePic5.Name = "dicePic5";
            this.dicePic5.Size = new System.Drawing.Size(114, 114);
            this.dicePic5.TabIndex = 7;
            this.dicePic5.TabStop = false;
            // 
            // dicePic4
            // 
            this.dicePic4.Image = global::WindowsFormsApplication1.Properties.Resources._1;
            this.dicePic4.Location = new System.Drawing.Point(372, 12);
            this.dicePic4.Name = "dicePic4";
            this.dicePic4.Size = new System.Drawing.Size(114, 114);
            this.dicePic4.TabIndex = 6;
            this.dicePic4.TabStop = false;
            // 
            // dicePic3
            // 
            this.dicePic3.Image = global::WindowsFormsApplication1.Properties.Resources._1;
            this.dicePic3.Location = new System.Drawing.Point(252, 12);
            this.dicePic3.Name = "dicePic3";
            this.dicePic3.Size = new System.Drawing.Size(114, 114);
            this.dicePic3.TabIndex = 5;
            this.dicePic3.TabStop = false;
            // 
            // dicePic2
            // 
            this.dicePic2.Image = global::WindowsFormsApplication1.Properties.Resources._1;
            this.dicePic2.Location = new System.Drawing.Point(132, 12);
            this.dicePic2.Name = "dicePic2";
            this.dicePic2.Size = new System.Drawing.Size(114, 114);
            this.dicePic2.TabIndex = 4;
            this.dicePic2.TabStop = false;
            // 
            // dicePic1
            // 
            this.dicePic1.Image = global::WindowsFormsApplication1.Properties.Resources._1;
            this.dicePic1.Location = new System.Drawing.Point(12, 12);
            this.dicePic1.Name = "dicePic1";
            this.dicePic1.Size = new System.Drawing.Size(114, 114);
            this.dicePic1.TabIndex = 3;
            this.dicePic1.TabStop = false;
            // 
            // scoreCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(616, 672);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.upperGrid);
            this.Controls.Add(this.lowerGrid);
            this.Controls.Add(this.dicePic5);
            this.Controls.Add(this.dicePic4);
            this.Controls.Add(this.dicePic3);
            this.Controls.Add(this.dicePic2);
            this.Controls.Add(this.dicePic1);
            this.Name = "scoreCard";
            this.Text = "scoreCard";
            this.Load += new System.EventHandler(this.scoreCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lowerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicePic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicePic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicePic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicePic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicePic1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox dicePic1;
        private System.Windows.Forms.PictureBox dicePic2;
        private System.Windows.Forms.PictureBox dicePic3;
        private System.Windows.Forms.PictureBox dicePic4;
        private System.Windows.Forms.PictureBox dicePic5;
        private System.Windows.Forms.DataGridView lowerGrid;
        private System.Windows.Forms.DataGridView upperGrid;
        private System.Windows.Forms.Button button1;
    }
}