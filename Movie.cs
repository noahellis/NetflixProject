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
        //Genre Comedy = new Genre("Comedy");
        //Genre Romance = new Genre("Romance");
        //Genre Action = new Genre("Action");
        //Genre All = new Genre("All");
        public Movie(string title, double rating, int durationInMinutes):base(title, rating, durationInMinutes)
        {
            this.title = title;
            this.durationInMinutes = durationInMinutes;
        }
        public Movie()
        {

        }
        //public void AddComedyMovie()
        //{
        //    Comedy.titleList.Add(new Movie("The Little Rascals", 4.5, 82));
        //    Comedy.titleList.Add(new Movie("Louis C.K.: Chewed Up", 4.5, 71));
        //    Comedy.titleList.Add(new Movie("Pirates of the Carribean: The Curse of the Black Pearl", 4, 143));
        //    Comedy.titleList.Add(new Movie("Talladega Nights: The Ballad of Ricky Bobby", 3, 108));
        //    Comedy.titleList.Add(new Movie("Team America: World Police", 3.5, 99));
        //    Comedy.titleList.Add(new Movie("Half Baked", 4, 82));
        //}
        //public void AddRomanceMovie()
        //{
        //    Romance.titleList.Add(new Movie("Silver Linings Playbook", 4.5, 122));
        //    Romance.titleList.Add(new Movie("Grease", 2.5, 110));
        //    Romance.titleList.Add(new Movie("Something's Gotta Give", 2.5, 128));
        //    Romance.titleList.Add(new Movie("The Switch", 3, 101));
        //    Romance.titleList.Add(new Movie("Say it isn't So", 2, 95));
        //    Romance.titleList.Add(new Movie("Seeking a Friend for the End of the World", 4, 101));
        //}
        //public void AddActionMovie()
        //{
        //    Action.titleList.Add(new Movie("Django Unchained", 5, 265));
        //    Action.titleList.Add(new Movie("Scarface", 5, 170));
        //    Action.titleList.Add(new Movie("Hot Fuzz", 4.5, 121));
        //    Action.titleList.Add(new Movie("Hellboy", 3, 132));
        //    Action.titleList.Add(new Movie("Sin City", 4, 147));
        //    Action.titleList.Add(new Movie("2001: A Space Odyssey", 4, 161));
        //}
        public override string ToString()
        {
            string movie = String.Format("The title of the movie is {0} and it is {1} minutes long", title, durationInMinutes);
            Console.WriteLine(movie);
            return movie;
        }
    }
}
