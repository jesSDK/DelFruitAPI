using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using HtmlAgilityPack;
using System.Collections.Specialized;

namespace DelfruitAPI
{
    public class DF
    {
        public class web
        {
            public static String Getmotd(string motd)
            {
                Console.WriteLine("Delfruit API - Getting Message of the Day!");
                HtmlWeb hweb = new HtmlWeb();
                HtmlDocument doc;
                string temp = "";
                try
                {
                    doc = hweb.Load("http://www.delicious-fruit.com/");
                    foreach (HtmlNode div1 in doc.DocumentNode.SelectNodes("//div[@style='position: relative; padding: 0.5em; background: #e8e8e8;']/p"))
                    {
                        
                          //  Console.WriteLine("MOTD is: " + div1.InnerText.ToString());
                            motd = div1.InnerText.ToString();
                            temp = div1.InnerText.ToString();
                         //   Console.ReadKey();
                        
                        
                    }
                    return temp;
                }catch(Exception ex)
                {
                    Console.WriteLine(ex);
                    Console.ReadKey();
                    return temp;
                }
                
            }


            public static String roll(string url, string gamename)
            {
                Console.WriteLine("Delfruit API - Getting random game!");
                HtmlWeb hweb = new HtmlWeb();
                HtmlDocument doc;
                url = "";
                gamename = "";
                try
                {
                    doc = hweb.Load("http://www.delicious-fruit.com/ratings/game_details.php?random=1");
                    hweb.ResponseUri.AbsolutePath.ToString();
                    url = hweb.ResponseUri.AbsolutePath.ToString();
                    return url;
                    foreach (HtmlNode gametitle in doc.DocumentNode.SelectNodes("//h1[@style='word-wrap: break-word;']"))
                    {
                        gamename = gametitle.InnerText.ToString();
                        return gamename;
                    }
                }catch(Exception ex)
                {
                    return ex.ToString();
                }
            }
        }
    }
}
