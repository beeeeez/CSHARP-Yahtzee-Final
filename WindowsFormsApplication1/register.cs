using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();

            




        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            validateMe temp = new validateMe();
            string msg = "";
            msg += temp.registerUser(userBox.Text);
            msg += temp.registerPass(passBox1.Text, passBox2.Text);

            if(msg == "")
            {
                sqlStuff tempSql = new sqlStuff();
                msg += tempSql.registerAccount(userBox.Text, passBox1.Text);
            }
            if(msg == "Account Successfully Registered!")
            {
                button1.Visible = false;
                button2.Text = "Finish";
            }

         err.Text = msg;
        }

    }
}
