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
    public partial class playboard : Form
    {

        public bool[] saveDice = new bool[5];
        public static int[] sortDice = new int[5];
        public static int[] diceValues = new int[5];
        public int rollCount = 0;
        public bool playingTime = true; 

        public playboard(string user, string pass)
        {
            InitializeComponent();

            userLb.Text = user;
            

        }

        public playboard()
        {
            InitializeComponent();
        }

        private void playboard_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 5; i++)
            {
                saveDice[i] = false;
                diceValues[i] = 0;
            }

            rollLb.Text = "Begin Rolling!";
            rollBtn.Text = "Start your 1st roll!";
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;


        }

        private void playboard_FormClosing(Object sender, FormClosingEventArgs e)
        {
            
        }

        private void rollBtn_Click(object sender, EventArgs e)
        {

                rollLb.Text = "Roll # : " + rollCount.ToString();
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
            

            playMode();
            //oooo boy here we go again
            if (rollCount > 2)
            {
                playingTime = false;
               
            }

            if (playingTime == false)
            {

                scoreMode();
                

                }//end of scoring mode


            else
            {
                
                Random diceRoll = new Random();



                for (int i = 0; i < 5; i++)
                {
                    if (saveDice[i] == false || diceValues[i] == 0)
                    {
                        diceValues[i] = diceRoll.Next(1, 7);
                    }

                }

                for (int i = 0; i < 5; i++)//i wanted to dynamically write the targets (dicepic1 or dicepic2 etc) dynamically. probably would've been much more efficient, but i just hit it with a hammer instead
                {
                    int holdMe;
                    holdMe = diceValues[i];

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


                rollCount++;


            }//out of playmode




        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(saveDice[0] == false)
            {
                saveDice[0] = true;
                button1.Text = "Unsave!";
                button1.BackColor = Color.FromArgb(25, 25, 112);
                button1.ForeColor = Color.FromArgb(255, 255, 255);
            }

            else if(saveDice[0] == true)
            {
                saveDice[0] = false;
                button1.Text = "Save!";
                button1.BackColor = Color.FromArgb(240, 240, 240);
                button1.ForeColor = Color.FromArgb(0, 0, 0);
            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (saveDice[1] == false)
            {
                saveDice[1] = true;
                button2.Text = "Unsave!";
                button2.BackColor = Color.FromArgb(25, 25, 112);
                button2.ForeColor = Color.FromArgb(255, 255, 255);
            }

            else if (saveDice[1] == true)
            {
                saveDice[1] = false;
                button2.Text = "Save!";
                button2.BackColor = Color.FromArgb(240, 240, 240);
                button2.ForeColor = Color.FromArgb(0, 0, 0);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (saveDice[2] == false)
            {
                saveDice[2] = true;
                button3.Text = "Unsave!";
                button3.BackColor = Color.FromArgb(25, 25, 112);
                button3.ForeColor = Color.FromArgb(255, 255, 255);
            }

            else if (saveDice[2] == true)
            {
                saveDice[2] = false;
                button3.Text = "Save!";
                button3.BackColor = Color.FromArgb(240, 240, 240);
                button3.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (saveDice[3] == false)
            {
                saveDice[3] = true;
                button4.Text = "Unsave!";
                button4.BackColor = Color.FromArgb(25, 25, 112);
                button4.ForeColor = Color.FromArgb(255, 255, 255);
            }

            else if (saveDice[3] == true)
            {
                saveDice[3] = false;
                button4.Text = "Save!";
                button4.BackColor = Color.FromArgb(240, 240, 240);
                button4.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (saveDice[4] == false)
            {
                saveDice[4] = true;
                button5.Text = "Unsave!";
                button5.BackColor = Color.FromArgb(25, 25, 112);
                button5.ForeColor = Color.FromArgb(255, 255, 255);
            }

            else if (saveDice[4] == true)
            {
                saveDice[4] = false;
                button5.Text = "Save!";
                button5.BackColor = Color.FromArgb(240, 240, 240);
                button5.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void dicePic3_Click(object sender, EventArgs e)
        {

        }

        private void acesBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void playMode()
        {
            acesButt.Visible = false;
            twosButt.Visible = false;
            threesButt.Visible = false;
            foursButt.Visible = false;
            fivesButt.Visible = false;
            sixesButt.Visible = false;
            threeofakindButt.Visible = false;
            fourofakindButt.Visible = false;
            fullhouseButt.Visible = false;
            smstraightButt.Visible = false;
            lgstraightButt.Visible = false;
            yahtzeeButt.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            rollBtn.Visible = true;
            


        }

        private void scoreMode()
        {
            acesButt.Visible = true;
            twosButt.Visible = true;
            threesButt.Visible = true;
            foursButt.Visible = true;
            fivesButt.Visible = true;
            sixesButt.Visible = true;
            threeofakindButt.Visible = true;
            fourofakindButt.Visible = true;
            fullhouseButt.Visible = true;
            smstraightButt.Visible = true;
            lgstraightButt.Visible = true;
            yahtzeeButt.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            rollBtn.Visible = false;

            rollLb.Text = "The Dice Have Been Sorted!";

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

        private void acesButt_Click(object sender, EventArgs e)
        {






        }
    }
}
