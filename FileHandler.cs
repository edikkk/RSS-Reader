using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RSS_Reader;
 
namespace RSS_Reader
{
    class FileHandler
    {
        static public List<string> ParseTxtToList(string target)
        {
            List<string> URLList = File.ReadLines(target).ToList();
            return URLList;
        }
    }
}