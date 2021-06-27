using System;
using System.Collections.Generic;
using System.Text;

namespace Assignemnt
{
    class Address
    {
        private string thana;
        private string home_district;
        private string phone_no;
        public void setAddress(string thana, string home, string phone)
        {
            this.thana = thana;
            this.home_district = home;
            this.phone_no = phone;
        }
        public string getAddress()
        {
            string add = "\nThana : \t\t" + thana + "\nHome district : \t" + home_district+"\nPhone no : \t\t"+phone_no;
            return add;
        }
    }
}
