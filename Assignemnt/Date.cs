using System;
using System.Collections.Generic;
using System.Text;

namespace Assignemnt
{
    class Date
    {
        private int jday;
        private int jmonth;
        private int jyear;

        private int day;
        private int month;
        private int year;
        public void setJoinDate(int day, int month, int year)
        {
            if (day <= 31 && month <= 12)
            {
                this.jday = day;
                this.jmonth = month;
                this.jyear = year;
            }
            else
            {
                Console.WriteLine("Invalid date--!!!!\n\n");
            }
        }
        public void setDOB(int day, int month, int year)
        {
            if (day <= 31 && month <= 12)
            {
                this.day = day;
                this.month = month;
                this.year = year;
            }
            else
            {
                Console.WriteLine("Invalid date--!!!!\n\n");
            }
        }
        public string getDOB()
        {
            string date = "" + day + " - " + month + " - " + year;
            return date;
        }
        public string getJoinDate()
        {
            string date = "" + jday + " - " + jmonth + " - " + jyear;
            return date;
        }
    }
}
