using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelfruitAPI;
using System.Collections.Specialized;

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
            Console.WriteLine("Printing game info");
            StringCollection game = new StringCollection();
            DelfruitAPI.roll.getgame(game);
            //prints all info
            //print seperate info
            Console.WriteLine("Game name: " + game[1] + "\r\n" + "Game Difficulty: " + game[3] + "\r\n" + "Game Rating: " + game[2] );
            Console.ReadKey();

        }
    }
}
