using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Movie
    {
        private string _title;
        private string _studio;
        private string _rating;
        

        public Movie (string title, string studio, string ratings)
        {
            this._title = title;
            this._studio = studio;
            this._rating = ratings;
        }

        public Movie (string title, string studio)
        {
            this._title = title;
            this._studio = studio;
            _rating = "PG";
        }

        public void PrintInfo ()
        {
            Console.WriteLine($"Title: {_title}");
            Console.WriteLine($"Studio: {_studio}");
            Console.WriteLine($"Raing: {_rating}");
        }
    }
}
