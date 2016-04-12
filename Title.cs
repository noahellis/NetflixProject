using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    class Title 
    {

        public string name;
        public double rating;
        public int lenghtInMinutes;
        public Title()
        {

        }
        public Title(string name, double rating, int lenghtInMinutes)
        {

        }

        public static Genre operator +(Title a, Title b)
        {
            a.name = "The Little Rascals";
            b.name = "Django Unchained";
            Genre aggregatedGenre = new Genre();
            aggregatedGenre.TitleList.Add(a);
            aggregatedGenre.TitleList.Add(b);
            return aggregatedGenre;
        }

    }
}
