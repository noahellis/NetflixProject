using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    class Movie : Title
    {        
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
            string movie = String.Format("The title of the movie is {0} and it is {1} minutes long", title, durationInMinutes);
            Console.WriteLine(movie);
            return movie;
        }
    }
}
