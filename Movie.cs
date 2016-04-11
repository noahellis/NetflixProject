using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    class Movie : Title
    {
        ////     Movie(Inherits from Title)
        ////-    Duration field
        ////-    Overrides ToString() method to return a string of the name and duration of the movie
        public string title;
        public int durationInMinutes;
        public Movie(string title, double rating, int durationInMinutes):base(title, rating, durationInMinutes)
        {
            this.title = title;
            this.durationInMinutes = durationInMinutes;
        }
        public Movie()
        {

        }
        public override string ToString()
        {
            return "Movie: " + title + " " + durationInMinutes;
        }
    }
}
