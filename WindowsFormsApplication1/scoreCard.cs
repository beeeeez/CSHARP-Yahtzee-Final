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
    public partial class scoreCard : Form
    {

        public int[] sortDice = new int[5];
        public int score = 0;
        public static DataSet upper = new DataSet();
        public static DataSet lower = new DataSet();
        






        private void populateUpper()
        {
         DataTable upperTable = upper.Tables.Add("UpperT");
         DataColumn titlesU = upperTable.Columns.Add("Titles", typeof(string));
         DataColumn descriptionsU = upperTable.Columns.Add("Description", typeof(string));
         DataColumn scoresU = upperTable.Columns.Add("Score", typeof(Int32));


        DataRow row1 = upperTable.Rows.Add();
            row1["Titles"] = "Aces";
            row1["Description"] = "Add only aces.";
            row1["Score"] = 0;

            DataRow row2 = upperTable.Rows.Add();
            row2["Titles"] = "Twos";
            row2["Description"] = "Add only twos.";
            row2["Score"] = 0;

            DataRow row3 = upperTable.Rows.Add();
            row3["Titles"] = "Threes";
            row3["Description"] = "Add only threes.";
            row3["Score"] = 0;

            DataRow row4 = upperTable.Rows.Add();
            row4["Titles"] = "Fours";
            row4["Description"] = "Add only fours.";
            row4["Score"] = 0;

            DataRow row5 = upperTable.Rows.Add();
            row5["Titles"] = "Fives";
            row5["Description"] = "Add only fives.";
            row5["Score"] = 0;

            DataRow row6 = upperTable.Rows.Add();
            row6["Titles"] = "Sixes";
            row6["Description"] = "Add only sixes.";
            row6["Score"] = 0;

            DataRow row7 = upperTable.Rows.Add();
            row7["Titles"] = "Total";
            row7["Description"] = "------->";
            row7["Score"] = 0;

            DataRow row8 = upperTable.Rows.Add();
            row8["Titles"] = "BONUS";
            row8["Description"] = "If 63 or more Score 35.";
            row8["Score"] = 0;

            DataRow row9 = upperTable.Rows.Add();
            row9["Titles"] = "Total of Upper Section";
            row9["Description"] = "------->";
            row9["Score"] = 0;

         
        }


        private void populateLower()
        {
         DataTable lowerTable = lower.Tables.Add("LowerT");
         DataColumn titlesL = lowerTable.Columns.Add("Titles", typeof(string));
         DataColumn descriptionsL = lowerTable.Columns.Add("Description", typeof(string));
         DataColumn scoresL = lowerTable.Columns.Add("Score", typeof(Int32));


        DataRow row1 = lowerTable.Rows.Add();
            row1["Titles"] = "3 of a Kind";
            row1["Description"] = "Add total of all dice.";
            row1["Score"] = 0;

            DataRow row2 = lowerTable.Rows.Add();
            row2["Titles"] = "4 of a Kind";
            row2["Description"] = "Add total of all dice.";
            row2["Score"] = 0;

            DataRow row3 = lowerTable.Rows.Add();
            row3["Titles"] = "FullHouse";
            row3["Description"] = "Score 25";
            row3["Score"] = 0;

            DataRow row4 = lowerTable.Rows.Add();
            row4["Titles"] = "Sm. Straight";
            row4["Description"] = "Score 30";
            row4["Score"] = 0;

            DataRow row5 = lowerTable.Rows.Add();
            row5["Titles"] = "Lg. Straight";
            row5["Description"] = "Score 40";
            row5["Score"] = 0;

            DataRow row6 = lowerTable.Rows.Add();
            row6["Titles"] = "YAHTZEE";
            row6["Description"] = "Score 50";
            row6["Score"] = 0;

            DataRow row7 = lowerTable.Rows.Add();
            row7["Titles"] = "Chance";
            row7["Description"] = "Add total of all dice.";
            row7["Score"] = 0;

            DataRow row8 = lowerTable.Rows.Add();
            row8["Titles"] = "YAHTZEE BONUS";
            row8["Description"] = "Score 100";
            row8["Score"] = 0;

            DataRow row9 = lowerTable.Rows.Add();
            row9["Titles"] = "Total of Lower Section";
            row9["Description"] = "------->";
            row9["Score"] = 0;

           
        }




        public scoreCard()
        {
       
            InitializeComponent();
            


        }

        private void scoreCard_Load(object sender, EventArgs e)
        {

            populateUpper();
            populateLower();

            lowerGrid.DataSource = upper;
            upperGrid.DataSource = lower;
            lowerGrid.DataMember = upper.Tables["UpperT"].ToString();
            upperGrid.DataMember = lower.Tables["LowerT"].ToString();


            int holdforSort;
            for (int i = 0; i < 5; i++)
            {
                sortDice[i] = playboard.diceValues[i];
            }

            for (int passes = 0; passes < 12; passes++)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (sortDice[i] > sortDice[i + 1])
                    {
                        holdforSort = sortDice[i];
                        sortDice[i] = sortDice[i + 1];
                        sortDice[i + 1] = holdforSort;
                    }
                }
            }//bubble trouble double bubble rubble double trouble



            for (int i = 0; i < 5; i++)//i wanted to dynamically write the targets (dicepic1 or dicepic2 etc) dynamically. probably would've been much more efficient, but i just hit it with a hammer instead
            {
                int holdMe;
                holdMe = sortDice[i];

                if (i == 0)
                {
                    if (holdMe == 1)
                    {
                        dicePic1.Image = WindowsFormsApplication1.Properties.Resources._1;
                    }
                    else if (holdMe == 2)
                    {
                        dicePic1.Image = WindowsFormsApplication1.Properties.Resources._2;
                    }
                    else if (holdMe == 3)
                    {
                        dicePic1.Image = WindowsFormsApplication1.Properties.Resources._3;
                    }
                    else if (holdMe == 4)
                    {
                        dicePic1.Image = WindowsFormsApplication1.Properties.Resources._4;
                    }
                    else if (holdMe == 5)
                    {
                        dicePic1.Image = WindowsFormsApplication1.Properties.Resources._5;
                    }
                    else if (holdMe == 6)
                    {
                        dicePic1.Image = WindowsFormsApplication1.Properties.Resources._6;
                    }
                }

                else if (i == 1)
                {
                    if (holdMe == 1)
                    {
                        dicePic2.Image = WindowsFormsApplication1.Properties.Resources._1;
                    }
                    else if (holdMe == 2)
                    {
                        dicePic2.Image = WindowsFormsApplication1.Properties.Resources._2;
                    }
                    else if (holdMe == 3)
                    {
                        dicePic2.Image = WindowsFormsApplication1.Properties.Resources._3;
                    }
                    else if (holdMe == 4)
                    {
                        dicePic2.Image = WindowsFormsApplication1.Properties.Resources._4;
                    }
                    else if (holdMe == 5)
                    {
                        dicePic2.Image = WindowsFormsApplication1.Properties.Resources._5;
                    }
                    else if (holdMe == 6)
                    {
                        dicePic2.Image = WindowsFormsApplication1.Properties.Resources._6;
                    }
                }

                if (i == 2)
                {
                    if (holdMe == 1)
                    {
                        dicePic3.Image = WindowsFormsApplication1.Properties.Resources._1;
                    }
                    else if (holdMe == 2)
                    {
                        dicePic3.Image = WindowsFormsApplication1.Properties.Resources._2;
                    }
                    else if (holdMe == 3)
                    {
                        dicePic3.Image = WindowsFormsApplication1.Properties.Resources._3;
                    }
                    else if (holdMe == 4)
                    {
                        dicePic3.Image = WindowsFormsApplication1.Properties.Resources._4;
                    }
                    else if (holdMe == 5)
                    {
                        dicePic3.Image = WindowsFormsApplication1.Properties.Resources._5;
                    }
                    else if (holdMe == 6)
                    {
                        dicePic3.Image = WindowsFormsApplication1.Properties.Resources._6;
                    }
                }

                if (i == 3)
                {
                    if (holdMe == 1)
                    {
                        dicePic4.Image = WindowsFormsApplication1.Properties.Resources._1;
                    }
                    else if (holdMe == 2)
                    {
                        dicePic4.Image = WindowsFormsApplication1.Properties.Resources._2;
                    }
                    else if (holdMe == 3)
                    {
                        dicePic4.Image = WindowsFormsApplication1.Properties.Resources._3;
                    }
                    else if (holdMe == 4)
                    {
                        dicePic4.Image = WindowsFormsApplication1.Properties.Resources._4;
                    }
                    else if (holdMe == 5)
                    {
                        dicePic4.Image = WindowsFormsApplication1.Properties.Resources._5;
                    }
                    else if (holdMe == 6)
                    {
                        dicePic4.Image = WindowsFormsApplication1.Properties.Resources._6;
                    }
                }

                if (i == 4)
                {
                    if (holdMe == 1)
                    {
                        dicePic5.Image = WindowsFormsApplication1.Properties.Resources._1;
                    }
                    else if (holdMe == 2)
                    {
                        dicePic5.Image = WindowsFormsApplication1.Properties.Resources._2;
                    }
                    else if (holdMe == 3)
                    {
                        dicePic5.Image = WindowsFormsApplication1.Properties.Resources._3;
                    }
                    else if (holdMe == 4)
                    {
                        dicePic5.Image = WindowsFormsApplication1.Properties.Resources._4;
                    }
                    else if (holdMe == 5)
                    {
                        dicePic5.Image = WindowsFormsApplication1.Properties.Resources._5;
                    }
                    else if (holdMe == 6)
                    {
                        dicePic5.Image = WindowsFormsApplication1.Properties.Resources._6;
                    }
                }







            }




           


        }




        private void AddVisibleChangedEventHandler()
        {
            this.VisibleChanged += new EventHandler(this.Label_VisibleChanged);
        }

        private void Label_VisibleChanged(object sender, EventArgs e)
        {
            



        }

        private void lowerGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void upperGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }


    }
