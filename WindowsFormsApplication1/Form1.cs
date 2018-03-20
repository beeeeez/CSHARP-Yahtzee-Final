/*Alright, so I got a bit ambitious with this project, and seeing how I'm finishing up on the due date, I'm really hoping there isn't any blaring holes in the code
 * 
 * Essentially, I remade the yahtzee program I made for the midterm in windows forms. It was a bit of a challenge due to my lack of knowledge on how datasets
 * and data grid view worked at its core, but doing this project definetly helped me learn a ton about them. 
 * 
 * Just the basicist basic breakdown : 
 * The user has to register in the loginattempt tables in order to "log in" to get to the letsplay game board screen. 
 * The user plays through the yahtzee game and at the end, the score, the username, and a datetime.now gets put into the leaderboard table in the database.
 * 
 * 
 * 
 * I added a seperate section of the program that specifically tries to hit all of the points the yahtzee game didn't cover with the final's requirements --
 * the things that i could think of that it didn't cover was the update/delete aspects of interacting with a SQL database as well as passing a ref variable
 * the seperate section taps into its own stealersWheel tables and attempts to emulate the general functionality of the previous labs on a much smaller scale
 * 
 * 
 * The one thing that i didn't do was having a class inherit variables and functions from a base class, but i didn't see it as a requirement, so i ommitted it
 * 
 * If i had to recreate this program again, i'd definetly try and break the letsplay class into more classes and be a bit more organized with it, there is an awful amount of code in one place
 * also, commenting outside of the letsplay class is definetly to be desired, but i don't think i wrote anything that was outside of the curriculum beyond the media stuff
 * and i probably should've really centered all of my validation inside the validateMe class but as I continued writing, it kept slipping my mind, so validation is kind of spread
 * throughout the entirety of the program, a lot of it is found in the sqlstuff class
 * I know its my job to make my code as easy to understand as possible at face value, but if there is any questions at all, send me a message through canvas or email and i'll respond asap
 * 
 * also, just to try clarify the database tables
 * the loginAttempt table just holds user and pass
 * the scores table holds a unique datetime that is just datetime.now of whenever the user finishes the game. probably not the smartest idea, it'll probably error out
 * if two people try to enter in scores at the same time
 * the stealersWheel table just holds a name, who, and where -- not the smartest idea either going into it seeing how where is a keyword in sql
 * 
 * 
 * 
 * */
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {
            register reg = new register();
            reg.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlStuff sqltemp = new sqlStuff();
            string msg = "";
            if(userBox.Text.Length < 1)
            {
                msg += "Please enter a username.\n";
            }
            if(passBox.Text.Length < 1)
            {
                msg += "Please enter a password.";
            }
            if(userBox.Text == "cool" && passBox.Text == "ranch") {
                admin otherStuff = new admin();
                otherStuff.Closed += (s, args) => this.Visible = true;//john is the man. 
                otherStuff.Show();
                this.Visible = false;

            }
            if (msg == "")
            {
                msg += sqltemp.loginAttempt(userBox.Text, passBox.Text);
            }
            err.Text = msg;
            if(err.Text == "")
            {
                letsPlay play = new letsPlay(userBox.Text, passBox.Text);
                play.Closed += (s, args) => this.Visible = true;//john is the man. 
                play.Show();
                this.Visible = false;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            leaderboards leader = new leaderboards();
            leader.Closed += (s, args) => this.Visible = true;//john is the man. 
            leader.Show();
            this.Visible = false;
        }
    }
}
