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
    public partial class leaderboards : Form
    {
        public leaderboards()
        {
            InitializeComponent();
        }

        private void leaderboards_Load(object sender, EventArgs e)
        {



          //  searchparameters searchMe = new searchparameters();
        }

        private void searchAllButton_Click(object sender, EventArgs e)
        {
            DataSet thedata = new DataSet();
            sqlStuff sql = new sqlStuff();
            thedata = sql.selectAll(thedata);
            thedataGrid.DataSource = thedata;
            thedataGrid.DataMember = thedata.Tables["fff"].ToString();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchparameters searchMe = new searchparameters(userBox.Text, scoreSearchbox.Text, dateSearch.Value.Date);
            DataSet thedata = new DataSet();
            thedata = searchMe.gimmietheData();
            thedataGrid.DataSource = thedata;
            thedataGrid.DataMember = thedata.Tables["fff"].ToString();
            DateTime tryme = dateSearch.Value.Date;

        }
    }
}
