using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    class Title 
    {
////        Title
////-    Name field
////-    Rating field
////-    Overload plus(+) operator to take in two Titles and return an aggregated Genre
////-    Offer two overloaded constructors: one that takes in all the fields and sets them, another that takes in no fields and sets the internal fields to null.

        //public Genre titleGenre = new Genre();
        public string name;
        public double rating;
        public int lenghtInMinutes;
        public Title()
        {

        }
        public Title(string name, double rating, int lenghtInMinutes)
        {

        }
        public Title(string titleA, string titleB)
        {

        }
        public static Genre operator +(Title a, Title b)
        {
            a.name = "The Little Rascals";
            b.name = "Django Unchained";
            Genre aggregatedGenre = new Genre();
            aggregatedGenre.titleList.Add(a);
            aggregatedGenre.titleList.Add(b);
            return aggregatedGenre;
        }
        public override string ToString()
        {
            return (string.Format("New Genre {0} + {1}", name, name));
        }
        //public static MakeGenre overload + (Title a + Title b)
        //public void PrintActionMovieList()
        //{
        //    StringBuilder actionBuilder = new StringBuilder();
        //    foreach (Movie actionMovie in titleGenre.actionMovieList)
        //    {
        //        actionBuilder.Append(actionBuilder).Append(":");
        //    }
        //    string actionBuilderString = actionBuilder.ToString();
        //    Console.Write(actionBuilderString);
        //}
        //public void ToString()
        //{

        //}

    }
}
