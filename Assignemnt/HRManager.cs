using System;
using System.Collections.Generic;
using System.Text;

namespace Assignemnt
{
    class HRManager:Employee
    {
        public HRManager(string name, string bg, string i, string type, float salary, string thana, string home, string phone)
        {
            setInfo(name, bg, i, type, salary, thana, home, phone);
        }
    }
}
