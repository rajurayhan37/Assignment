using System;

namespace Assignemnt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\t\tIT Employee: \n\n");
            IT it = new IT("Rayhan", "O+","E-0002","IT Executive",1000,"Vatara","Naogaon","01318182316");
            it.setJoinDate(31, 3, 2021);
            it.setDOB(30, 3, 2021);
            it.getInfo();

            Console.Write("\t\tHR Employee: \n\n");
            HRManager hr = new HRManager("Raju", "A+", "E-00202", "HR Manager", 9000, "Nikunja", "Kustia", "01718182316");
            hr.setJoinDate(1, 10, 2011);
            hr.setDOB(30, 3, 1990);
            hr.getInfo();

            Console.Write("\t\tMarketing Employee: \n\n");
            MarketAnalyst ma = new MarketAnalyst("Safa", "AB+", "E-09102", "Market Analyst", 20000, "Asulia", "Bagerhat", "01518182316");
            ma.setJoinDate(1, 10, 2001);
            ma.setDOB(12, 10, 1985);
            ma.getInfo();

            Console.Write("\t\tPart Timer Employee: \n\n");
            Part_timer pr = new Part_timer("Jony", "B+", "E-01102", "Part timer", 2000, "Netrokona", "Khulna", "01618182316");
            pr.setJoinDate(1, 10, 2020);
            pr.setDOB(12, 10, 1999);
            pr.getInfo();
        }
    }
}
