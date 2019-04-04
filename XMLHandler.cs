using System;
using System.Collections.Generic;
using System.Net;
using System.Xml;
using System.Xml.Linq;
using System.Linq;
using RSS_Reader;


namespace RSS_Reader
{
    public class XMLHandler
    {
        static public List<XML> ParseToStringList(XmlDocument xmlDoc)
        {
            XmlNodeList title = xmlDoc.GetElementsByTagName("title");
            XmlNodeList link = xmlDoc.GetElementsByTagName("link");

            List<XML> xmlList = new List<XML>();

            for (int i = 1; i < title.Count; i++)
            {
                xmlList.Add(new XML(title[i].InnerText, link[i].InnerText));
            }

            return xmlList;
        }
        /* static public List<XML> TestConcatXMLList(params List<XML>[] xmlLists)
        {
            List<XML> baseList = new List<XML>();
            foreach (List<XML> list in xmlLists)
            {
                baseList.Concat(list);
            }
            baseList.Insert(0, new XML("",""));

            return baseList;
        }*/
        static public XmlDocument SingleDownloader(string url)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(url); 

            return xmlDoc;
        }
         static public List<XML> ConcatXMLList(List<String> URLs)
        {
            List<XML> baseList = new List<XML>();
            foreach (string link in URLs)
            {
                var temp = ParseToStringList(SingleDownloader(link));
                baseList.AddRange(temp);
            }
            baseList.Insert(0, new XML("",""));

            return baseList;
        }
    }
}