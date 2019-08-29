using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Date
    {
        private string _month;
        private string _day;
        private string _year;

        public void DisplayDate ()
        {
            _day = DateTime.Now.ToString("dd");
            _month = DateTime.Now.ToString("MM");
            _year = DateTime.Now.ToString("yyyy");

            Console.WriteLine($"Current date is: {_day}/{_month}/{_year}");
        }
    }
}
