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
        //public void AddActionMovie()
        //{

        //    titleGenre.actionMovieList.Add(new Title("Django Unchained", 5));//, 265
        //    titleGenre.actionMovieList.Add(new Title("Scarface", 5));//, 170
        //    titleGenre.actionMovieList.Add(new Title("Hot Fuzz", 4.5));//, 121
        //    titleGenre.actionMovieList.Add(new Title("Hellboy", 3));//, 132
        //    titleGenre.actionMovieList.Add(new Title("Sin City", 4));//, 147
        //    titleGenre.actionMovieList.Add(new Title("2001, A Space Odyssey", 4));//, 161

        //}
        //public void AddComedyMovies()
        //{

        //    titleGenre.comedyMovieList.Add(new Title("The Little Rascals", 4.5));//, 82
        //    titleGenre.comedyMovieList.Add(new Title("Louis C.K.: Chewed Up", 4.5));//, 71
        //    titleGenre.comedyMovieList.Add(new Title("Pirates of the Caribbean: The Curse of the Black Pearl", 4));//, 143
        //    titleGenre.comedyMovieList.Add(new Title("Talladega Nights: The Ballad of Ricky Bobby", 3));//, 108
        //    titleGenre.comedyMovieList.Add(new Title("Team America: World Police", 3.5));//, 99
        //    titleGenre.comedyMovieList.Add(new Title("HalfBaked", 4));//, 82
        //}
        //public void AddRomanceMovies()
        //{
            
        //    titleGenre.romanceMovieList.Add(new Title("Silver Linings Playbook", 4.5));//, 122
        //    titleGenre.romanceMovieList.Add(new Title("Grease", 2.5));//, 110
        //    titleGenre.romanceMovieList.Add(new Title("Something's Gotta Give", 2.5));//, 128
        //    titleGenre.romanceMovieList.Add(new Title("The Switch", 3));//, 101
        //    titleGenre.romanceMovieList.Add(new Title("Say it isn't So", 2));//, 95
        //    titleGenre.romanceMovieList.Add(new Title("Seeking a Friend for the End of the World", 4));//, 101
        //}

    }
}
