using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelfruitAPI;

namespace DFAPIDebugging
{
    class Program
    {
        static void Main(string[] args)
        {
            string motd = "";
            string gamename = "";
            string url = "";
              
          //gets message of the day and stores it in supplied string
            Console.WriteLine(DF.web.Getmotd(motd));
            Console.WriteLine("");
            Console.WriteLine(DF.web.roll(url, gamename));
            Console.ReadKey();
        }
    }
}
