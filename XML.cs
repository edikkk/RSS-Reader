using System;
using System.Collections.Generic;
using RSS_Reader;
 
namespace RSS_Reader
{
    public class XML
    {
        private string title;
        private string url;

        public XML(string title, string url)
        {
            this.title = title;
            this.url = url;
        }

        public string Title
        {
            get{ return title; }
            set{ title = value; }
        }

        public string URL
        {
            get{ return url; }
            set{ url = value; }
        }
    }

}