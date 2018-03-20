using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class createOrUpdate : Form
    {
        public string msg ="";
        public sqlStuff sql = new sqlStuff();
        public DataSet theData = new DataSet();


        public createOrUpdate(object row)
        {
            InitializeComponent();
            nameStatic.Text = row.ToString();
            theData = sql.searchSomeRealBuds(row.ToString(), "Any", "Any");
            DataTable dt = new DataTable();
            dt = theData.Tables["fff"];
            foreach (DataRow dr in dt.Rows)
            {
                nameBox.Text = dr["name"].ToString();
                whoBox.Text = dr["who"].ToString().ToString();
                whereBox.Text = dr["whereat"].ToString();
            }
            open();
       }

        public createOrUpdate()
        {
            InitializeComponent();
            deleteButton.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nameBox.Text.Length < 1)
            {
                msg = "You have to enter a name in the box.";
            }
            else
            {
                msg = sql.createRealBuds(nameBox.Text, whoBox.Text, whereBox.Text);
              
                closeMe();
                
            }
            errLb.Text = msg;
            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (nameBox.Text.Length < 1)
            {
                msg = "You have to enter a name in the box.";

            }
            else
            {
                msg = sql.updateRealBuds(nameBox.Text, whoBox.Text, whereBox.Text, nameStatic.Text);
                closeMe();

                errLb.Text = msg;
            }
        }

        private void createOrUpdate_Load(object sender, EventArgs e)
        {
            quitButton.Visible = false;

        }

        public void closeMe()
        {
            updateButton.Visible = false;
            createNewButton.Visible = false;
            quitButton.Visible = true;
            deleteButton.Visible = false;
        }

        public void open()
        {
            updateButton.Visible = true;
            createNewButton.Visible = true;
            quitButton.Visible = false;
            deleteButton.Visible = true;
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            msg = sql.deleteRealBuds(nameStatic.Text);

            closeMe();
            errLb.Text = msg;


        }
    }
}
