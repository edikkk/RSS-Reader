using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using RSS_Reader;
 
namespace RSS_Reader
{
    class Program
    {           /* TODO: LIST OF URLS EXTENSION
                         CONFIG FILE W/ SEPERATE RSS FEEDS */
        public const string TXT = "\\rss.txt";            
        private static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory();
            string target = path + TXT;

            List<XML> menuItem = XMLHandler.ConcatXMLList(FileHandler.ParseTxtToList(target));

            Console.CursorVisible = false;
            Console.Clear();
            while (true)
            {
                int selectedMenuItem = Menu.Draw(menuItem);

                if (selectedMenuItem != 0) 
                {
                    Process openUrl = new Process();
                    try
                    {
                        openUrl.StartInfo.UseShellExecute = true; 
                        openUrl.StartInfo.FileName = menuItem[selectedMenuItem].URL;
                        openUrl.Start();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                Console.Clear();
            }
        }
    }
}