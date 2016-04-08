using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    class Genre
    {
        public List<Title> titleList;
        public string genreType;
        Title useTitle = new Title();
        public void AddTitle(Title title)
        {
            
        }
        //public List<Title> actionMovieList = new List<Title>();
        //public List<Title> romanceMovieList = new List<Title>();
        //public List<Title> comedyMovieList = new List<Title>();
        //public Genre (string title, double rating, int lenghtInMinutes)
        //{
        //    //List<Title> titleList = new List<Title>();
        //    //List<Action> actionList = new List<Action>();
        //    //List<Romance> romanceList = new List<Romance>();
        //    //List<Comedy> comedyList = new List<Comedy>();
        //}
        //public Genre()
        //{

        //}
        //public enum Genres
        //{            
        //    All =0,
        //    Romance=1,
        //    Comedy=2,
        //    Action=4,
        //}       
        //public void PrintAction()
        //{
        //    foreach (Action movie in actionList)
        //    {
        //        Console.WriteLine(movie);
        //    }
        //}
        //public static Genre operator + (Genre Comedy, Genre Romance)
        //{
        //    Genre romCom = new Genre();
        //    romCom = Comedy.comedyList + Romance.romanceList;
        //    return romCom;
        //}
    }
}
