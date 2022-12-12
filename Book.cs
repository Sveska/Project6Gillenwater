using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj6
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public string Publisher { get; set; }
        public void Print()
        {
            Console.WriteLine(Title + "" + Author + "" + Pages + "" + Publisher);
        }
    }
}
