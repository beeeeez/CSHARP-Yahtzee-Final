namespace WindowsFormsApplication1
{
    partial class register
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
            this.userBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(37, 34);
            this.userBox.MaxLength = 12;
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(143, 20);
            this.userBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(40, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Desired Username : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(69, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password : ";
            // 
            // passBox1
            // 
            this.passBox1.Location = new System.Drawing.Point(37, 80);
            this.passBox1.MaxLength = 12;
            this.passBox1.Name = "passBox1";
            this.passBox1.PasswordChar = '*';
            this.passBox1.Size = new System.Drawing.Size(143, 20);
            this.passBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(45, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirm Password : ";
            // 
            // passBox2
            // 
            this.passBox2.Location = new System.Drawing.Point(37, 128);
            this.passBox2.MaxLength = 12;
            this.passBox2.Name = "passBox2";
            this.passBox2.PasswordChar = '*';
            this.passBox2.Size = new System.Drawing.Size(143, 20);
            this.passBox2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(48, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // err
            // 
            this.err.AutoSize = true;
            this.err.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.err.ForeColor = System.Drawing.Color.Red;
            this.err.Location = new System.Drawing.Point(12, 246);
            this.err.Name = "err";
            this.err.Size = new System.Drawing.Size(51, 15);
            this.err.TabIndex = 8;
            this.err.Text = "Danger!";
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(215, 296);
            this.ControlBox = false;
            this.Controls.Add(this.err);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userBox);
            this.MaximumSize = new System.Drawing.Size(231, 335);
            this.MinimumSize = new System.Drawing.Size(231, 335);
            this.Name = "register";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label err;
    }
}