using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace WindowsFormsApplication1
{
    public partial class admin : Form
    {

        public sqlStuff sql = new sqlStuff();
        public Random rando = new Random();


        public admin()
        {
            InitializeComponent();
        }

        private void buttonButton_Click(object sender, EventArgs e)
        {
            int number = 0;
            decideWhattoPlay(ref number);
            switch (number)
            {// lets get better at switch case too
                case 1:
                    SoundPlayer simpleSound1 = new SoundPlayer(WindowsFormsApplication1.Properties.Resources.random1);
                    simpleSound1.Play();
                    break;
                case 2:
                    SoundPlayer simpleSound2 = new SoundPlayer(WindowsFormsApplication1.Properties.Resources.random2);
                    simpleSound2.Play();
                    break;
                case 3:
                    SoundPlayer simpleSound3 = new SoundPlayer(WindowsFormsApplication1.Properties.Resources.random3);
                    simpleSound3.Play();
                    break;
                case 4:
                    SoundPlayer simpleSound4 = new SoundPlayer(WindowsFormsApplication1.Properties.Resources.random4);
                    simpleSound4.Play();
                    break;
                case 5:
                    SoundPlayer simpleSound5 = new SoundPlayer(WindowsFormsApplication1.Properties.Resources.random5);
                    simpleSound5.Play();
                    break;
                case 6:
                    SoundPlayer simpleSound6 = new SoundPlayer(WindowsFormsApplication1.Properties.Resources.random6);
                    simpleSound6.Play();
                    break;
                case 7:
                    SoundPlayer simpleSound7 = new SoundPlayer(WindowsFormsApplication1.Properties.Resources.random7);
                    simpleSound7.Play();
                    break;
                case 8:
                    SoundPlayer simpleSound8 = new SoundPlayer(WindowsFormsApplication1.Properties.Resources.random8);
                    simpleSound8.Play();
                    break;
                case 9:
                    SoundPlayer simpleSound9 = new SoundPlayer(WindowsFormsApplication1.Properties.Resources.random9);
                    simpleSound9.Play();
                    break;
                case 10:
                    SoundPlayer simpleSound10 = new SoundPlayer(WindowsFormsApplication1.Properties.Resources.random10);
                    simpleSound10.Play();
                    break;
                case 11:
                    SoundPlayer simpleSound11 = new SoundPlayer(WindowsFormsApplication1.Properties.Resources.random11);
                    simpleSound11.Play();
                    break;
                case 12:
                    SoundPlayer simpleSound12 = new SoundPlayer(WindowsFormsApplication1.Properties.Resources.random12);
                    simpleSound12.Play();
                    break;
                case 13:
                    SoundPlayer simpleSound13 = new SoundPlayer(WindowsFormsApplication1.Properties.Resources.random13);
                    simpleSound13.Play();
                    break;
                case 14:
                    SoundPlayer simpleSound14 = new SoundPlayer(WindowsFormsApplication1.Properties.Resources.random14);
                    simpleSound14.Play();
                    break;
                case 15:
                    SoundPlayer simpleSound15 = new SoundPlayer(WindowsFormsApplication1.Properties.Resources.random15);
                    simpleSound15.Play();
                    break;
                case 16:
                    SoundPlayer simpleSound16= new SoundPlayer(WindowsFormsApplication1.Properties.Resources.random16);
                    simpleSound16.Play();
                    break;
                case 17:
                    SoundPlayer simpleSound17 = new SoundPlayer(WindowsFormsApplication1.Properties.Resources.random17);
                    simpleSound17.Play();
                    break;
                case 18:
                    SoundPlayer simpleSound18 = new SoundPlayer(WindowsFormsApplication1.Properties.Resources.random18);
                    simpleSound18.Play();
                    break;
                case 19:
                    SoundPlayer simpleSound19 = new SoundPlayer(WindowsFormsApplication1.Properties.Resources.random19);
                    simpleSound19.Play();
                    break;
                case 20:
                    SoundPlayer simpleSound20 = new SoundPlayer(WindowsFormsApplication1.Properties.Resources.random20);
                    simpleSound20.Play();
                    break;
            }


        }

        private void newButton_Click(object sender, EventArgs e)
        {

        }

        private void searchAllButton_Click(object sender, EventArgs e)
        {
            DataSet temp = new DataSet();
            temp = sql.searchAllRealBuds();
            theData.DataSource = temp;
            theData.DataMember = temp.Tables["fff"].ToString();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DataSet temp = new DataSet();
            temp = sql.searchSomeRealBuds(nameBox.Text, whoBox.Text, whereBox.Text);
            theData.DataSource = temp;
            theData.DataMember = temp.Tables["fff"].ToString();
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            createOrUpdate buffs = new createOrUpdate(theData.Rows[e.RowIndex].Cells[0].Value);
            buffs.Closed += (s, args) => this.Visible = true;//john is the man. 
            buffs.Show();
            this.Visible = false;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            createOrUpdate bloods = new createOrUpdate();
            bloods.Closed += (s, args) => this.Visible = true;//john is the man. 
            bloods.Show();
            this.Visible = false;
        }

        public void decideWhattoPlay(ref int number)//gotta jam ref into it somewhere
        {
            number = rando.Next(1, 20);


        }
    }
}
