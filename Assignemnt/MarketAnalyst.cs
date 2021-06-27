using System;
using System.Collections.Generic;
using System.Text;

namespace Assignemnt
{
    class MarketAnalyst:Employee
    {
        public MarketAnalyst(string name, string bg, string i, string type, float salary, string thana, string home, string phone)
        {
            setInfo(name, bg, i, type, salary, thana, home, phone);
        }
    }
}
