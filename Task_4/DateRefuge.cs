using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class DateRefuge
    {

        public DateTime MyDate { get; set; }


        public DateRefuge(string date)
        {
            this.MyDate = DateTime.Parse(date);
        }

        public DateRefuge()
        {

        }


        public static DateRefuge operator +(DateRefuge a, int namdata)
        {
            a.MyDate = a.MyDate.AddDays(namdata);

            return new DateRefuge($"{a.MyDate.Day}/{a.MyDate.Month}/{a.MyDate.Year}");

        }

        public static int operator -(DateRefuge a, DateRefuge b)
        {
            TimeSpan time = a.MyDate - b.MyDate;
            return time.Days;
        }



    }
}
