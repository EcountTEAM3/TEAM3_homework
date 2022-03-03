using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_class
{
    internal class book
    {
        string name;
        string writer;
        string maker;
        int year;

        public book(string name, string writer)
        {
            this.name = name;
            this.writer = writer;
        }
        public book(string name, string writer, string maker, int year)
        {
            this.name = name;
            this.writer = writer;
            this.maker = maker;
            this.year = year;
        }


    }
}
