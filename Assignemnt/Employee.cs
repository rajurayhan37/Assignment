using System;
using System.Collections.Generic;
using System.Text;

namespace Assignemnt
{
    class Employee: Date
    {
        private string name;
        private string bg;
        private string id;
        private float salary;
        private string usertype;

        private string thana;
        private string home_district;
        private string phone_no;

        private float commission = 100;
        private float KPI = 5000;
        private float project_bonus = 2000;


        public void setInfo(string name, string bg, string i,string type, float salary,string thana,string home, string phone)
        {

            this.usertype = type;
            this.salary = salary;
            this.name = name;
            this.bg = bg;
            this.id = i;
            this.thana = thana;
            this.home_district = home;
            this.phone_no = phone;

        }
        public void getInfo()
        {
            if (usertype == "IT Executive")
            {
                this.salary += project_bonus;
            }
            if(usertype == "HR Manager")
            {
                this.salary += KPI;
            }
            if(usertype=="Market Analyst")
            {
                this.salary += commission;
            }
            Console.WriteLine("Id : \t\t\t" + id + "\nName : \t\t\t" + name+ "\nBlood group : \t\t" + bg+ "\nDate of Birth : \t" + getDOB() + "\nJoin Date : \t\t" + getJoinDate()+ "\nSalary : \t\t"+salary+"\nUser type: \t\t"+usertype+ "\nThana : \t\t" + thana + "\nHome district : \t" + home_district + "\nPhone no : \t\t" + phone_no+"\n\n");
        }
    }
}
