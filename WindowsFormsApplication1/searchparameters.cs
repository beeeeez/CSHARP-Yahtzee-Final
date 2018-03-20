using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApplication1
{
    public class searchparameters//this is so cheeeeeeeesy its delicious - i just made this to pass stuff around and try to prove that i know how get set works
    {
        public sqlStuff sql = new sqlStuff();
        public DataSet thedata = new DataSet();
        public string name;
        public string score;
        public DateTime date; 

        public searchparameters(string name, string score, DateTime date)
        {
            this.Name = name;
            this.Score = score;
            this.Date = date;        
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Score
        {
            get { return score; }
            set { score = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public DataSet gimmietheData()
        {
            return thedata = sql.selectSome(name, score, date);

        }



    }
}
