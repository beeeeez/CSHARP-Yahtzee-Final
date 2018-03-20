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
    public partial class letsPlay : Form//lets try this again
    {
        //class global variables and suchhh
        public bool[] saveDice = new bool[5];
        public int[] valueDice = new int[5];
        public int rollCount = 0;
        public bool isitScoringMode = false;
        public int score = 0;
        public int tempScore = 0;
        public static DataSet upper = new DataSet();
        public static DataSet lower = new DataSet();





        public letsPlay(string user, string pass)
        {
            InitializeComponent();
            userLb.Text = user;//sets the name at the top to the "logged in" user
        }



        public void playMode()// beginning of play mode function ****************************************************************
        {
            resetDice();
            rollCountLb.Text = "Roll #1";
            rollCount = 0;
            scoreSelection.Visible = false;
            scoreButton.Visible = false;
            scoreLb.Text = score.ToString();
            changetheSavebuttons("reset");
        }//end of playmode function -------------------------------------------------------------------



        public void scoringMode() // beginning of scoring more function *************************************************************
        {
            turnoffSavebuttons();
            rollCountLb.Text = "It's Time to Score!";
        }//end of scoringmode function -------------------------------------------------------------



        private void letsPlay_Load(object sender, EventArgs e) // the intial loading function of the letsplay Form *********************************************************
        {
            endgameLb.Visible = false;
            endtheGamebutton.Visible = false;
            populatetheTables();
            for (int i = 0; i < 5; i++)//initializes the dice to have 0 for values;
            {
                saveDice[i] = false;
                valueDice[i] = 0;
            }
            playMode();
            

        }//end of letsPlay loading function -------------------------------------------------------------------------

        private void switchModes()// the function that handles switching between play mode and scoring mode  *********************************************************
        {
            if (isitScoringMode == false)
            {
                isitScoringMode = true;
                scoringMode();
            }
            else
            {
                isitScoringMode = false;
                playMode();
            }
        }// end of the function that handles switching between playmode and scoring more -----------------------------------------------------------------------------


        private void rollDicebutton_Click(object sender, EventArgs e)//the function that executes when the roll the dice button is clicked during playmode ***********************************
        {
            turnonSavebuttons();
            SoundPlayer simpleSound = new SoundPlayer(WindowsFormsApplication1.Properties.Resources.roll1);
            simpleSound.Play();
            Random diceRoll = new Random();
            for (int i = 0; i < 5; i++)//rolls random numbers for all five dice and assigns the random numbers to an int array
            {
                if (saveDice[i] == false || valueDice[i] == 0)
                {
                    valueDice[i] = diceRoll.Next(1, 7);
                }
            }//end of the the dice assignment

            setPicturevalues();

            rollCount++;
            if(rollCount == 1)
            {
                rollCountLb.Text = "Roll #2";
            }
            else if (rollCount == 2)
            {
                rollCountLb.Text = "Roll #3\nScores are locked after this roll!";
            }
            if (rollCount > 2)
            {
                switchModes();
            }

        }//end of the roll the dice button click function -------------------------------------------------------------------------------------------


        private void scoreButton_Click(object sender, EventArgs e)//the function that executes when the score the dice button is clicked in scoring mode ***************************
        {
            tempScore = 0; // reset the temp score variable

            if (scoreSelection.Text == "Aces")
            {
                for (int i = 0; i < 5; i++)
                {
                    if (valueDice[i] == 1)
                    {
                        tempScore++;
                    }
                }//end of score counting forloop
                updateTheTables("Aces", tempScore);
                scoreSelection.Items.Remove("Aces");
                score = score + tempScore;
                switchModes();
            }//end of aces


            else if (scoreSelection.Text == "Twos")
            {
                for (int i = 0; i < 5; i++)
                {
                    if (valueDice[i] == 2)
                    {
                        tempScore = tempScore + 2;
                    }
                }//end of score counting forloop
                updateTheTables("Twos", tempScore);
                scoreSelection.Items.Remove("Twos");
                score = score + tempScore;
                switchModes();
            }//end of twos

            else if (scoreSelection.Text == "Threes")
            {
                for (int i = 0; i < 5; i++)
                {
                    if (valueDice[i] == 3)
                    {
                        tempScore = tempScore + 3;
                    }
                }//end of score counting forloop
                updateTheTables("Threes", tempScore);
                scoreSelection.Items.Remove("Threes");
                score = score + tempScore;
                switchModes();
            }//end of threes

            else if (scoreSelection.Text == "Fours")
            {
                for (int i = 0; i < 5; i++)
                {
                    if (valueDice[i] == 4)
                    {
                        tempScore = tempScore + 4;
                    }
                }//end of score counting forloop
                updateTheTables("Fours", tempScore);
                scoreSelection.Items.Remove("Fours");
                score = score + tempScore;
                switchModes();
            }//end of fours

            else if (scoreSelection.Text == "Fives")
            {
                for (int i = 0; i < 5; i++)
                {
                    if (valueDice[i] == 5)
                    {
                        tempScore = tempScore + 5;
                    }
                }//end of score counting forloop
                updateTheTables("Fives", tempScore);
                scoreSelection.Items.Remove("Fives");
                score = score + tempScore;
                switchModes();
            }//end of fives

            else if (scoreSelection.Text == "Sixes")
            {
                for (int i = 0; i < 5; i++)
                {
                    if (valueDice[i] == 6)
                    {
                        tempScore = tempScore + 6;
                    }
                }//end of score counting forloop
                updateTheTables("Sixes", tempScore);
                scoreSelection.Items.Remove("Sixes");
                score = score + tempScore;
                switchModes();
            }//end of sixes


            else if (scoreSelection.Text == "3 Of A Kind")
            {
                bool threeofakind = false;
                for (int i = 1; i <= 6; i++)
                {
                    int numberofmatches = 0;
                    for (int j = 0; j < 5; j++)
                    {
                        if (valueDice[j] == i)
                        {
                            numberofmatches++;
                            if (numberofmatches > 2)
                            {
                                threeofakind = true;
                            }
                        }
                    }

                }

                if (threeofakind == true)
                {
                    for (int k = 0; k < 5; k++)
                    {

                        tempScore += valueDice[k];
                    }
                }
                updateTheTables("3 Of A Kind", tempScore);
                scoreSelection.Items.Remove("3 Of A Kind");
                score = score + tempScore;
                switchModes();
            }



            else if (scoreSelection.Text == "4 Of A Kind")
            {
                bool fourofakind = false;
                for (int i = 1; i <= 6; i++)
                {
                    int numberofmatches = 0;
                    for (int j = 0; j < 5; j++)
                    {
                        if (valueDice[j] == i)
                        {
                            numberofmatches++;
                            if (numberofmatches > 3)
                            {
                                fourofakind = true;
                            }
                        }
                    }

                }

                if (fourofakind == true)
                {
                    for (int k = 0; k < 5; k++)
                    {

                        tempScore += valueDice[k];
                    }
                }
                updateTheTables("4 Of A Kind", tempScore);
                scoreSelection.Items.Remove("4 Of A Kind");
                score = score + tempScore;
                switchModes();
            }

            else if(scoreSelection.Text == "Full House")
            {
                int[] i = new int[5];
                i[0] = valueDice[0];
                i[1] = valueDice[1];
                i[2] = valueDice[2];
                i[3] = valueDice[3];
                i[4] = valueDice[4];

                Array.Sort(i);
                if ((((i[0] == i[1]) && (i[1] == i[2])) && // Three of a Kind
                   (i[3] == i[4]) && // Two of a Kind
                   (i[2] != i[3])) ||
                  ((i[0] == i[1]) && // Two of a Kind
                   ((i[2] == i[3]) && (i[3] == i[4])) && // Three of a Kind
                   (i[1] != i[2])))
                    {
                    tempScore = 25;                    
                    }
                updateTheTables("Full House", tempScore);
                scoreSelection.Items.Remove("Full House");
                score = score + tempScore;
                switchModes();
            }

            else if (scoreSelection.Text == "Small Straight")
            {
                int[] i = new int[5];
                i[0] = valueDice[0];
                i[1] = valueDice[1];
                i[2] = valueDice[2];
                i[3] = valueDice[3];
                i[4] = valueDice[4];

                Array.Sort(i);
                for (int j = 0; j < 4; j++)
                {
                    int temp = 0;
                    if (i[j] == i[j + 1])
                    {
                        temp = i[j];

                        for (int k = j; k < 4; k++)
                        {
                            i[k] = i[k + 1];
                        }

                        i[4] = temp;
                    }
                }

                if (((i[0] == 1) && (i[1] == 2) && (i[2] == 3) && (i[3] == 4)) ||
                    ((i[0] == 2) && (i[1] == 3) && (i[2] == 4) && (i[3] == 5)) ||
                    ((i[0] == 3) && (i[1] == 4) && (i[2] == 5) && (i[3] == 6)) ||
                    ((i[1] == 1) && (i[2] == 2) && (i[3] == 3) && (i[4] == 4)) ||
                    ((i[1] == 2) && (i[2] == 3) && (i[3] == 4) && (i[4] == 5)) ||
                    ((i[1] == 3) && (i[2] == 4) && (i[3] == 5) && (i[4] == 6)))
                {
                    tempScore = 30;
                }
                updateTheTables("Sm. Straight", tempScore);
                scoreSelection.Items.Remove("Small Straight");
                score = score + tempScore;
                switchModes();
            }

            else if (scoreSelection.Text == "Large Straight")
            {
                int[] i = new int[5];
                i[0] = valueDice[0];
                i[1] = valueDice[1];
                i[2] = valueDice[2];
                i[3] = valueDice[3];
                i[4] = valueDice[4];

                Array.Sort(i);
                for (int j = 0; j < 4; j++)
                {
                    int temp = 0;
                    if (i[j] == i[j + 1])
                    {
                        temp = i[j];

                        for (int k = j; k < 4; k++)
                        {
                            i[k] = i[k + 1];
                        }

                        i[4] = temp;
                    }
                }

                if (((i[0] == 1) &&
                       (i[1] == 2) &&
                       (i[2] == 3) &&
                       (i[3] == 4) &&
                       (i[4] == 5)) ||
                      ((i[0] == 2) &&
                       (i[1] == 3) &&
                       (i[2] == 4) &&
                       (i[3] == 5) &&
                       (i[4] == 6)))
                {
                    tempScore = 40;
                }
                updateTheTables("Lg. Straight", tempScore);
                scoreSelection.Items.Remove("Large Straight");
                score = score + tempScore;
                switchModes();
            }

            else if (scoreSelection.Text == "Chance")
            {
                for(int i =0; i < 5; i++)
                {
                    tempScore += valueDice[i];
                }
                updateTheTables("Chance", tempScore);
                scoreSelection.Items.Remove("Chance");
                score = score + tempScore;
                switchModes();

            }
            else if(scoreSelection.Text == "YAHTZEE")
            {
                bool yahtzee = false;
                for (int i = 1; i <= 6; i++)
                {
                    int numberofmatches = 0;
                    for (int j = 0; j < 5; j++)
                    {
                        if (valueDice[j] == i)
                        {
                            numberofmatches++;
                            if (numberofmatches > 4)
                            {
                                yahtzee = true;
                            }
                        }
                    }
                }
                if (yahtzee == true)
                {
                    tempScore = 50;
                }
                    score = score + tempScore;
                    updateTheTables("YAHTZEE", tempScore);
                    scoreSelection.Items.Remove("YAHTZEE");
                scoreSelection.Items.Add("YAHTZEE BONUS");
                switchModes();
            }

            else if(scoreSelection.Text == "YAHTZEE BONUS")
            {
                bool yahtzee = false;
                for (int i = 1; i <= 6; i++)
                {
                    int numberofmatches = 0;
                    for (int j = 0; j < 5; j++)
                    {
                        if (valueDice[j] == i)
                        {
                            numberofmatches++;
                            if (numberofmatches > 4)
                            {
                                yahtzee = true;
                            }
                        }
                    }
                }
                if (yahtzee == true)
                {
                    tempScore = 100;
                }
                score = score + tempScore;
                updateTheTables("YAHTZEE BONUS", tempScore);
                switchModes();

            }

        

            else
            {
                rollCountLb.Text = "You need to pick a selection from the drop down box.";               
            }

            autoUpdateScores();
            thegameisOver(userLb.Text);

        }//end of the score the dice button function -------------------------------------------------------------------------------




        // ------------------------------------------------------------------------------------------The end of the Main Functions -----------------------------------------------------------------------------------

        private void resetDice()//this function resets the dice pictures everytime you re-enter the playmode ************************************************************
        {
            dicePic1.Image = WindowsFormsApplication1.Properties.Resources._0;
            dicePic2.Image = WindowsFormsApplication1.Properties.Resources._0;
            dicePic3.Image = WindowsFormsApplication1.Properties.Resources._0;
            dicePic4.Image = WindowsFormsApplication1.Properties.Resources._0;
            dicePic5.Image = WindowsFormsApplication1.Properties.Resources._0;
            rollDicebutton.Visible = true;
        } // end of the function that resets the dice pictures everytime you re-enter playmode-------------------------------------------------------------------------



        private void setPicturevalues() // This function sets the picture sources for the dice pictures ****************************************************************
        {
            for (int i = 0; i < 5; i++)//i wanted to dynamically write the targets (dicepic1 or dicepic2 etc) dynamically. probably would've been much more efficient, but i just hit it with a hammer instead
            {
                int holdMe;
                holdMe = valueDice[i];

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


        }// end of the function that sets the pictures every roll --------------------------------------------------------------------------------




        private void turnonSavebuttons() // beginning of the function that turns on the save buttons ****************************************************
        {
            save1.Visible = true;
            save2.Visible = true;
            save3.Visible = true;
            save4.Visible = true;
            save5.Visible = true;
            rollDicebutton.Visible = true;
        }//end of the function that turns on the save buttons -------------------------------------------------------------------------------------

        private void turnoffSavebuttons() // beginning of the function that turns off the save buttons ****************************************************
        {
            save1.Visible = false;
            save2.Visible = false;
            save3.Visible = false;
            save4.Visible = false;
            save5.Visible = false;
            rollDicebutton.Visible = false;
            scoreSelection.Visible = true;
            scoreButton.Visible = true;

        }//end of the function that turns off the save buttons -------------------------------------------------------------------------------------

      


        public void populatetheTables() // beginning of the function that handles the datagridview initilization and population ********************************************* 
        {
            if (!upper.Tables.Contains("upperT") && !lower.Tables.Contains("lowerT"))
            {
                DataTable lowerTable = lower.Tables.Add("LowerT");
                DataColumn titlesL = lowerTable.Columns.Add("Titles", typeof(string));
                DataColumn descriptionsL = lowerTable.Columns.Add("Description", typeof(string));
                DataColumn scoresL = lowerTable.Columns.Add("Score", typeof(string));

                DataRow lrow1 = lowerTable.Rows.Add();
                lrow1["Titles"] = "Aces";
                lrow1["Description"] = "Add only aces.";
                lrow1["Score"] = "---";

                DataRow lrow2 = lowerTable.Rows.Add();
                lrow2["Titles"] = "Twos";
                lrow2["Description"] = "Add only twos.";
                lrow2["Score"] = "---";

                DataRow lrow3 = lowerTable.Rows.Add();
                lrow3["Titles"] = "Threes";
                lrow3["Description"] = "Add only threes.";
                lrow3["Score"] = "---";

                DataRow lrow4 = lowerTable.Rows.Add();
                lrow4["Titles"] = "Fours";
                lrow4["Description"] = "Add only fours.";
                lrow4["Score"] = "---";

                DataRow lrow5 = lowerTable.Rows.Add();
                lrow5["Titles"] = "Fives";
                lrow5["Description"] = "Add only fives.";
                lrow5["Score"] = "---";

                DataRow lrow6 = lowerTable.Rows.Add();
                lrow6["Titles"] = "Sixes";
                lrow6["Description"] = "Add only sixes.";
                lrow6["Score"] = "---";

                DataRow lrow7 = lowerTable.Rows.Add();
                lrow7["Titles"] = "Total";
                lrow7["Description"] = "------->";
                lrow7["Score"] = "---";

                DataRow lrow8 = lowerTable.Rows.Add();
                lrow8["Titles"] = "BONUS";
                lrow8["Description"] = "If 63 or more Score 35.";
                lrow8["Score"] = "---";

                DataRow lrow9 = lowerTable.Rows.Add();
                lrow9["Titles"] = "Lower Section Total";
                lrow9["Description"] = "------->";
                lrow9["Score"] = "---";

                DataTable upperTable = upper.Tables.Add("UpperT");
                DataColumn titlesU = upperTable.Columns.Add("Titles", typeof(string));
                DataColumn descriptionsU = upperTable.Columns.Add("Description", typeof(string));
                DataColumn scoresU = upperTable.Columns.Add("Score", typeof(string));

                DataRow urow1 = upperTable.Rows.Add();
                urow1["Titles"] = "3 of a Kind";
                urow1["Description"] = "Add total of all dice.";
                urow1["Score"] = "---";

                DataRow urow2 = upperTable.Rows.Add();
                urow2["Titles"] = "4 of a Kind";
                urow2["Description"] = "Add total of all dice.";
                urow2["Score"] = "---";

                DataRow urow3 = upperTable.Rows.Add();
                urow3["Titles"] = "Full House";
                urow3["Description"] = "Score 25";
                urow3["Score"] = "---";

                DataRow urow4 = upperTable.Rows.Add();
                urow4["Titles"] = "Sm. Straight";
                urow4["Description"] = "Score 30";
                urow4["Score"] = "---";

                DataRow urow5 = upperTable.Rows.Add();
                urow5["Titles"] = "Lg. Straight";
                urow5["Description"] = "Score 40";
                urow5["Score"] = "---";

                DataRow urow6 = upperTable.Rows.Add();
                urow6["Titles"] = "YAHTZEE";
                urow6["Description"] = "Score 50";
                urow6["Score"] = "---";

                DataRow urow7 = upperTable.Rows.Add();
                urow7["Titles"] = "Chance";
                urow7["Description"] = "Add total of all dice.";
                urow7["Score"] = "---";

                DataRow urow8 = upperTable.Rows.Add();
                urow8["Titles"] = "YAHTZEE BONUS";
                urow8["Description"] = "Score 100";
                urow8["Score"] = "---";

                DataRow urow9 = upperTable.Rows.Add();
                urow9["Titles"] = "Upper Section Total";
                urow9["Description"] = "------->";
                urow9["Score"] = "---";
                                                
            }
            DataRow[] lrow = lower.Tables["lowerT"].Select();
            DataRow[] urow = upper.Tables["upperT"].Select();

            for(int i = 0; i <9; i++)// gotta reset the scores everytime they close and open this
            {
                lrow[i]["Score"] = "---";
                urow[i]["Score"] = "---";
            }



            lowerGrid.DataSource = lower;
            upperGrid.DataSource = upper;
            lowerGrid.DataMember = lower.Tables["LowerT"].ToString();
            upperGrid.DataMember = upper.Tables["UpperT"].ToString();
        }// end of data table population function --------------------------------------------------------------------------------------------------------------------




        private void updateTheTables(string title, int score)// the function that updates the tabels on the screen to reflect the scorecard **************************************************
        {
            if (title == "Aces")// i really need to learn when to use switch case
            {
                DataRow[] changethisRow = lower.Tables["lowerT"].Select("Titles = 'Aces'");
                changethisRow[0]["Score"] = score.ToString();
            }
            else if (title == "Twos")
            {
                DataRow[] changethisRow = lower.Tables["lowerT"].Select("Titles = 'Twos'");
                changethisRow[0]["Score"] = score.ToString();
            }
            else if (title == "Threes")
            {
                DataRow[] changethisRow = lower.Tables["lowerT"].Select("Titles = 'Threes'");
                changethisRow[0]["Score"] = score.ToString();
            }
            else if (title == "Fours")
            {
                DataRow[] changethisRow = lower.Tables["lowerT"].Select("Titles = 'Fours'");
                changethisRow[0]["Score"] = score.ToString();
            }
            else if (title == "Fives")
            {
                DataRow[] changethisRow = lower.Tables["lowerT"].Select("Titles = 'Fives'");
                changethisRow[0]["Score"] = score.ToString();
            }
            else if (title == "Sixes")
            {
                DataRow[] changethisRow = lower.Tables["lowerT"].Select("Titles = 'Sixes'");
                changethisRow[0]["Score"] = score.ToString();
            }
            else if (title == "3 Of A Kind")
            {
                DataRow[] changethisRow = upper.Tables["upperT"].Select("Titles = '3 Of A Kind'");
                changethisRow[0]["Score"] = score.ToString();
            }
            else if (title == "4 Of A Kind")
            {
                DataRow[] changethisRow = upper.Tables["upperT"].Select("Titles = '4 Of A Kind'");
                changethisRow[0]["Score"] = score.ToString();
            }
            else if (title == "Full House")
            {
                DataRow[] changethisRow = upper.Tables["upperT"].Select("Titles = 'Full House'");
                changethisRow[0]["Score"] = score.ToString();
            }
            else if (title == "Sm. Straight")
            {
                DataRow[] changethisRow = upper.Tables["upperT"].Select("Titles = 'Sm. Straight'");
                changethisRow[0]["Score"] = score.ToString();
            }
            else if (title == "Lg. Straight")
            {
                DataRow[] changethisRow = upper.Tables["upperT"].Select("Titles = 'Lg. Straight'");
                changethisRow[0]["Score"] = score.ToString();
            }
            else if (title == "Chance")
            {
                DataRow[] changethisRow = upper.Tables["upperT"].Select("Titles = 'Chance'");
                changethisRow[0]["Score"] = score.ToString();
            }
            else if (title == "YAHTZEE")
            {
                DataRow[] changethisRow = upper.Tables["upperT"].Select("Titles = 'YAHTZEE'");
                changethisRow[0]["Score"] = score.ToString();
            }
            else if (title == "YAHTZEE BONUS")
            {
                
                DataRow[] changethisRow = upper.Tables["upperT"].Select("Titles = 'YAHTZEE BONUS");
                if (changethisRow[0]["Score"].ToString() == "---")
                {
                    changethisRow[0]["Score"] = score.ToString();
                }
                else
                {
                    int temp;
                    Int32.TryParse(changethisRow[0]["Score"].ToString(), out temp);
                    score = temp + score;
                    changethisRow[0]["Score"] = score.ToString();
                }

            }
        

    
        }// end of the function that updates the tables on the screen to reflect the scorecard ---------------------------------------------------------------------------------------------------------

        private void autoUpdateScores()//This function handles the auto updating of the static elements of the score card (ie total score)*********************************************
        {//i just need to get this done alreadyyyyyyyyyyyyyyyyyyyyyyy so much to gooooooooo
            DataRow[] totalLower = lower.Tables["lowerT"].Select("Titles ='Total'");
            DataRow[] bonus = lower.Tables["lowerT"].Select("Titles = 'BONUS'");
            DataRow[] totalFullLower = lower.Tables["lowerT"].Select("Titles ='Lower Section Total'");
            DataRow[] totalUpper = upper.Tables["upperT"].Select("Titles = 'Upper Section Total'");

            DataRow[] aces  = lower.Tables["lowerT"].Select("Titles ='Aces'");
            DataRow[] twos = lower.Tables["lowerT"].Select("Titles ='Twos'");
            DataRow[] threes = lower.Tables["lowerT"].Select("Titles ='Threes'");
            DataRow[] fours = lower.Tables["lowerT"].Select("Titles ='Fours'");
            DataRow[] fives = lower.Tables["lowerT"].Select("Titles ='Fives'");
            DataRow[] sixes = lower.Tables["lowerT"].Select("Titles ='Sixes'");

            DataRow[] threeofakind = upper.Tables["upperT"].Select("Titles = '3 Of A Kind'");
            DataRow[] fourofakind = upper.Tables["upperT"].Select("Titles = '4 Of A Kind'");
            DataRow[] fullhouse = upper.Tables["upperT"].Select("Titles = 'Full House'");
            DataRow[] smStraight = upper.Tables["upperT"].Select("Titles = 'Sm. Straight'");
            DataRow[] lgStraight = upper.Tables["upperT"].Select("Titles = 'Lg. Straight'");
            DataRow[] chance = upper.Tables["upperT"].Select("Titles = 'Chance'");
            DataRow[] yahtzee = upper.Tables["upperT"].Select("Titles = 'YAHTZEE'");
            DataRow[] yahtzeeB = upper.Tables["upperT"].Select("Titles = 'YAHTZEE BONUS'");

            int acesC, twosC, threesC, foursC, fivesC, sixesC, threeofakindC, fourofakindC, fullhouseC, smStraightC, lgStraightC, chanceC, yahtzeeC, yahtzeeBC;

            Int32.TryParse(aces[0]["Score"].ToString(), out acesC);// I just had to have my labels "---" for unassigned scores :L
            Int32.TryParse(twos[0]["Score"].ToString(), out twosC);
            Int32.TryParse(threes[0]["Score"].ToString(), out threesC);
            Int32.TryParse(fours[0]["Score"].ToString(), out foursC);
            Int32.TryParse(fives[0]["Score"].ToString(), out fivesC);
            Int32.TryParse(sixes[0]["Score"].ToString(), out sixesC);


            Int32.TryParse(threeofakind[0]["Score"].ToString(), out threeofakindC);
            Int32.TryParse(fourofakind[0]["Score"].ToString(), out fourofakindC);
            Int32.TryParse(fullhouse[0]["Score"].ToString(), out fullhouseC);
            Int32.TryParse(smStraight[0]["Score"].ToString(), out smStraightC);
            Int32.TryParse(lgStraight[0]["Score"].ToString(), out lgStraightC);
            Int32.TryParse(chance[0]["Score"].ToString(), out chanceC);
            Int32.TryParse(yahtzee[0]["Score"].ToString(), out yahtzeeC);
            Int32.TryParse(yahtzeeB[0]["Score"].ToString(), out yahtzeeBC);

            int totalC, bonusC, lowerSectionC, upperSectionC;

            totalC = acesC + twosC + threesC + foursC + fivesC + sixesC;
            if (totalC >= 63)
            {
                bonusC = 35;
            }
            else
            {
                bonusC = 0;
            }

            lowerSectionC = totalC + bonusC;
            upperSectionC = threeofakindC + fourofakindC + fullhouseC + smStraightC + lgStraightC + chanceC + yahtzeeC + yahtzeeBC;
            totalLower[0]["Score"] = totalC.ToString();
            bonus[0]["Score"] = bonusC.ToString();
            totalFullLower[0]["Score"] = lowerSectionC.ToString();
            totalUpper[0]["Score"] = upperSectionC.ToString();

        }//end of the auto updating table function ------------------------------------------------------------------------------------------------


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void changetheSavebuttons(string parameters)// this function handles the save buttons states and whatnot *****************************************************
        {
            if (parameters == "save1")
            {
                if (saveDice[0] == false)
                {
                    saveDice[0] = true;
                    save1.Text = "Unsave!";
                    save1.BackColor = Color.FromArgb(25, 25, 112);
                    save1.ForeColor = Color.FromArgb(255, 255, 255);
                }

                else if (saveDice[0] == true)
                {
                    saveDice[0] = false;
                    save1.Text = "Save!";
                    save1.BackColor = Color.FromArgb(240, 240, 240);
                    save1.ForeColor = Color.FromArgb(0, 0, 0);
                }
            }

            else if (parameters == "save2")
            {
                if (saveDice[1] == false)
                {
                    saveDice[1] = true;
                    save2.Text = "Unsave!";
                    save2.BackColor = Color.FromArgb(25, 25, 112);
                    save2.ForeColor = Color.FromArgb(255, 255, 255);
                }

                else if (saveDice[1] == true)
                {
                    saveDice[1] = false;
                    save2.Text = "Save!";
                    save2.BackColor = Color.FromArgb(240, 240, 240);
                    save2.ForeColor = Color.FromArgb(0, 0, 0);
                }
            }

            else if (parameters == "save3")
            {
                if (saveDice[2] == false)
                {
                    saveDice[2] = true;
                    save3.Text = "Unsave!";
                    save3.BackColor = Color.FromArgb(25, 25, 112);
                    save3.ForeColor = Color.FromArgb(255, 255, 255);
                }

                else if (saveDice[2] == true)
                {
                    saveDice[2] = false;
                    save3.Text = "Save!";
                    save3.BackColor = Color.FromArgb(240, 240, 240);
                    save3.ForeColor = Color.FromArgb(0, 0, 0);
                }
            }

            else if (parameters == "save4")
            {
                if (saveDice[3] == false)
                {
                    saveDice[3] = true;
                    save4.Text = "Unsave!";
                    save4.BackColor = Color.FromArgb(25, 25, 112);
                    save4.ForeColor = Color.FromArgb(255, 255, 255);
                }

                else if (saveDice[3] == true)
                {
                    saveDice[3] = false;
                    save4.Text = "Save!";
                    save4.BackColor = Color.FromArgb(240, 240, 240);
                    save4.ForeColor = Color.FromArgb(0, 0, 0);
                }
            }

            else if (parameters == "save5")
            {
                if (saveDice[4] == false)
                {
                    saveDice[4] = true;
                    save5.Text = "Unsave!";
                    save5.BackColor = Color.FromArgb(25, 25, 112);
                    save5.ForeColor = Color.FromArgb(255, 255, 255);
                }

                else if (saveDice[4] == true)
                {
                    saveDice[4] = false;
                    save5.Text = "Save!";
                    save5.BackColor = Color.FromArgb(240, 240, 240);
                    save5.ForeColor = Color.FromArgb(0, 0, 0);
                }
            }
            else if (parameters == "reset"){
                saveDice[0] = false;
                save1.Text = "Save!";
                save1.BackColor = Color.FromArgb(240, 240, 240);
                save1.ForeColor = Color.FromArgb(0, 0, 0);

                saveDice[1] = false;
                save2.Text = "Save!";
                save2.BackColor = Color.FromArgb(240, 240, 240);
                save2.ForeColor = Color.FromArgb(0, 0, 0);

                saveDice[2] = false;
                save3.Text = "Save!";
                save3.BackColor = Color.FromArgb(240, 240, 240);
                save3.ForeColor = Color.FromArgb(0, 0, 0);

                saveDice[3] = false;
                save4.Text = "Save!";
                save4.BackColor = Color.FromArgb(240, 240, 240);
                save4.ForeColor = Color.FromArgb(0, 0, 0);

                saveDice[4] = false;
                save5.Text = "Save!";
                save5.BackColor = Color.FromArgb(240, 240, 240);
                save5.ForeColor = Color.FromArgb(0, 0, 0);

            }


        }// end of the the function that handles the save button states ----------------------------------------------------------------------------------------

        private void thegameisOver(string user)//this function checks to see if the game is overr ****************************************************************
        {
            if(scoreSelection.Items.Contains("Aces") != true && // what a sexy conditional
                scoreSelection.Items.Contains("Twos") != true &&
                scoreSelection.Items.Contains("Threes") != true &&
                scoreSelection.Items.Contains("Fours") != true &&
                scoreSelection.Items.Contains("Fives") != true &&
                scoreSelection.Items.Contains("Sixes") != true &&
                scoreSelection.Items.Contains("3 Of A Kind") != true &&
                scoreSelection.Items.Contains("4 Of A Kind") != true &&
                scoreSelection.Items.Contains("Full House") != true &&
                scoreSelection.Items.Contains("Small Straight") != true &&
                scoreSelection.Items.Contains("Large Straight") != true &&
                scoreSelection.Items.Contains("Chance") != true &&
                scoreSelection.Items.Contains("YAHTZEE") != true)
            {
                sqlStuff temp = new sqlStuff();
                string msg = temp.sendScores(user, score);
                rollCountLb.Visible = false;
                dicePic1.Visible = false;
                dicePic2.Visible = false;
                dicePic3.Visible = false;
                dicePic4.Visible = false;
                dicePic5.Visible = false;
                rollDicebutton.Visible = false;
                endtheGamebutton.Visible = true;
                endgameLb.Visible = true;
                endgameLb.Text = msg;
            }
        }//end of the function that checks to see if the game is over ------------------------------------------------------------------------------------  

        private void save1_Click(object sender, EventArgs e)
        {
            changetheSavebuttons("save1");
        }


        private void save2_Click(object sender, EventArgs e)
        {
            changetheSavebuttons("save2");
        }

        private void save3_Click(object sender, EventArgs e)
        {
            changetheSavebuttons("save3");
        }

        private void save4_Click(object sender, EventArgs e)
        {
            changetheSavebuttons("save4");
        }

        private void save5_Click(object sender, EventArgs e)
        {
            changetheSavebuttons("save5");
        }

        private void endtheGamebutton_Click(object sender, EventArgs e)// this function closes the form and such***************************************************************
        {
            this.Close();
        }
    }//end of letsplay form
}
