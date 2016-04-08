using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    class Movie : Title
    {

        public Movie(string title, double rating, int durationInMinutes):base(title, rating)
        {

        }
        public Movie()
        {

        }  

    }
}
