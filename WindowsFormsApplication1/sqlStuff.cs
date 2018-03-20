using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApplication1
{
    public class sqlStuff
    {



        public string registerAccount(string username, string password)
        {
            try
            {
                string connString = "Data Source = sql.neit.edu,4500; Initial Catalog =SE245_CBrown; User ID=se245_Cbrown; Password=Hsilop401;";
                SqlConnection connection = new SqlConnection(connString);
                string selectStatement = "insert into loginFinal(username, password)values(@User, @Pass)";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                selectCommand.Parameters.AddWithValue("@User", username);
                selectCommand.Parameters.AddWithValue("@Pass", password);
                connection.Open();
                SqlDataReader sqlReader = selectCommand.ExecuteReader();
                sqlReader.Read();
                connection.Close();
                string msg = "Account Successfully Registered!";
                return msg;
            }
            catch
            {
               string msg = "You must pick a unique username!";
               return msg;
            }
        }

        public string loginAttempt(string username, string password) {
                try
                {
                    string msg = "";
                    string connString = "Data Source = sql.neit.edu,4500; Initial Catalog =SE245_CBrown; User ID=se245_Cbrown; Password=Hsilop401;";
                    SqlConnection connection = new SqlConnection(connString);
                    string selectStatement = "select * from loginFinal where username = @User";
                    SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                    selectCommand.Parameters.AddWithValue("@User", username);
                    connection.Open();
                    SqlDataReader sqlData = selectCommand.ExecuteReader();
                    sqlData.Read();
                    string compareUser = sqlData["username"].ToString();
                    string comparePass = sqlData["password"].ToString();
                connection.Close();
                    if (comparePass != password)//passwords arent case sensitive because i need to be a better programmer
                    {
                        msg += "Your password doesn't match. \nPlease try again.";
                        return msg;
                    }
                    return msg;
                }
                catch
                { 
                      string msg = "Your username wasn't found. \nPlease register.";
                      return msg;
                 }
            }

        public string sendScores(string username, int score)
        {
            string msg = "";
            DateTime date = new DateTime();
            date = DateTime.Now;
            string connString = "Data Source = sql.neit.edu,4500; Initial Catalog =SE245_CBrown; User ID=se245_Cbrown; Password=Hsilop401;";
            SqlConnection connection = new SqlConnection(connString);
            string selectStatement = "insert into Scores(loggedDate, username, score)values(@Date, @User, @Score)";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@Date", date);
            selectCommand.Parameters.AddWithValue("@User", username);
            selectCommand.Parameters.AddWithValue("@Score", score);
            connection.Open();
            SqlDataReader sqlReader = selectCommand.ExecuteReader();
            sqlReader.Read();
            connection.Close();
            msg = "Score of " + score +" has been registered into the database!";
            return msg;
        }

        public DataSet selectAll(DataSet thedata)
        {
            string connString = "Data Source = sql.neit.edu,4500; Initial Catalog =SE245_CBrown; User ID=se245_Cbrown; Password=Hsilop401;";
            SqlConnection connection = new SqlConnection(connString);
            string selectStatement = "Select * from scores";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            connection.Open();
            SqlDataAdapter dataShmata = new SqlDataAdapter();
            dataShmata.SelectCommand = selectCommand;
            dataShmata.Fill(thedata, "fff");
            connection.Close();
            return thedata;
        }

        public DataSet selectSome(string user, string score, DateTime date)
        {
            
            DataSet thedata = new DataSet();
            string connString = "Data Source = sql.neit.edu,4500; Initial Catalog =SE245_CBrown; User ID=se245_Cbrown; Password=Hsilop401;";
            SqlConnection connection = new SqlConnection(connString);
            string selectStatement = "Select * from scores where 0=0 ";
            if(user.Length > 0)
            {
                selectStatement += " And username like @User";
            }
            if(score.Length > 0)
            {
                selectStatement += " And score like @Score";
            }
            selectStatement += " and loggeddate between @Date and @Date2";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@User", "%" + user + "%");
            selectCommand.Parameters.AddWithValue("@Score", "%" + score + "%");
            selectCommand.Parameters.AddWithValue("@Date", date);
            selectCommand.Parameters.AddWithValue("@Date2", date.AddDays(1));
            connection.Open();
            SqlDataAdapter dataShmata = new SqlDataAdapter();
            dataShmata.SelectCommand = selectCommand;
            dataShmata.Fill(thedata, "fff");
            connection.Close();
            return thedata;

        }

        public string createRealBuds(string name, string who, string where)
        {
            try
            {
            string msg ="";
            string connString = "Data Source = sql.neit.edu,4500; Initial Catalog =SE245_CBrown; User ID=se245_Cbrown; Password=Hsilop401;";
            SqlConnection connection = new SqlConnection(connString);
            string selectStatement = "insert into stealersWheel(name, who, whereat)values(@Name, @Who, @Where)";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@Name", name);
            selectCommand.Parameters.AddWithValue("@Who", who);
            selectCommand.Parameters.AddWithValue("@Where", where);
            connection.Open();
            SqlDataReader sqlData = selectCommand.ExecuteReader();
            sqlData.Read();
            connection.Close();
             msg = "Real Bud created successfully!";
                return msg;
            }
            catch
            {
                string msg = "You must pick a unique name!";
                return msg;
            }

        }

        public DataSet searchAllRealBuds()
        {
            DataSet thedata = new DataSet();
            string connString = "Data Source = sql.neit.edu,4500; Initial Catalog =SE245_CBrown; User ID=se245_Cbrown; Password=Hsilop401;";
            SqlConnection connection = new SqlConnection(connString);
            string selectStatement = "select * from stealersWheel";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            connection.Open();
            SqlDataAdapter dataShmata = new SqlDataAdapter();
            dataShmata.SelectCommand = selectCommand;
            dataShmata.Fill(thedata, "fff");
            connection.Close();
            return thedata;
        }


        public DataSet searchSomeRealBuds(string name, string who, string where)
        {
            DataSet thedata = new DataSet();
            string connString = "Data Source = sql.neit.edu,4500; Initial Catalog =SE245_CBrown; User ID=se245_Cbrown; Password=Hsilop401;";
            SqlConnection connection = new SqlConnection(connString);
            string selectStatement = "select * from stealersWheel where 0=0 ";
            if(name.Length > 1)
            {
                selectStatement += " and name like @Name ";
            }
            if (who != "Any")
            {
                selectStatement += " and who like @Who ";
            }
            if (where != "Any")
            {
                selectStatement += " and whereat like @Where ";
            }

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@Name", "%" + name + "%");
            selectCommand.Parameters.AddWithValue("@Who", "%" + who + "%");
            selectCommand.Parameters.AddWithValue("@Where", "%" + where + "%");
            connection.Open();
            SqlDataAdapter dataShmata = new SqlDataAdapter();
            dataShmata.SelectCommand = selectCommand;
            dataShmata.Fill(thedata, "fff");
            connection.Close();
            return thedata;
        }


        public string updateRealBuds(string name, string who, string where, string real)
        {
            try
            {
                string msg ="";
                string connString = "Data Source = sql.neit.edu,4500; Initial Catalog =SE245_CBrown; User ID=se245_Cbrown; Password=Hsilop401;";
                SqlConnection connection = new SqlConnection(connString);
                string selectStatement = "update stealersWheel set name = @Name, who = @Who, whereat = @Where where name = @Real";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                selectCommand.Parameters.AddWithValue("@Name", name);
                selectCommand.Parameters.AddWithValue("@Who", who);
                selectCommand.Parameters.AddWithValue("@Where", where);
                selectCommand.Parameters.AddWithValue("@Real", real);
                connection.Open();
                SqlDataReader sqlData = selectCommand.ExecuteReader();
                sqlData.Read();
                connection.Close();
                msg = "Real Bud Updated successfully!";
                return msg;
            }
            catch
            {
                string msg = "That name doesn't exist yet!";
                return msg;
            }
        }


        public string deleteRealBuds(string name)
        {
            try
            {
                string msg = "";
                string connString = "Data Source = sql.neit.edu,4500; Initial Catalog =SE245_CBrown; User ID=se245_Cbrown; Password=Hsilop401;";
                SqlConnection connection = new SqlConnection(connString);
                string selectStatement = "delete from stealersWheel where name = @Name";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                selectCommand.Parameters.AddWithValue("@Name", name);
                connection.Open();
                SqlDataReader sqlData = selectCommand.ExecuteReader();
                sqlData.Read();
                connection.Close();
                msg = "Real Bud Deleted successfully!";
                return msg;
            }
            catch
            {
                string msg = "Go back and double click a field!";
                return msg;
            }

        }


          }//end of the main form thing container thing



    }

