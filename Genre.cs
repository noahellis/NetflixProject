﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    class Genre
    {
////        Genre
////-    Contains a list of Titles
////-    Implement custom iterator to iterate over those Titles
////-    Overload plus(+) operator to take in two Genres and return the aggregated Genre.
////o For example, if we want to create an aggregated genre Romantic Comedy, all the film titles in that specific genre would include film titles from Romance and film titles from Comedy.
////-    Overload plus (+) operator to take in a Genre and a Title to return the aggregated Genre.
////o Take in a title, add it to the genre, return an aggregated list.
////o For example, title Die Hard and genre Comedy would return a list of all comedy films and Die Hard.
////-    Create the genres: All, Romance, Action, Comedy.They need to share some titles(such as Romantic Comedies) by reference, not by duplicating the title itself.
        public List<Title> titleList = new List<Title>();
        public string genreType;
        public Genre mixedGenre;
        public Genre genre1;
        public Genre genre2;
        Catalog getCatalog = new Catalog();
        Title useTitle = new Title();
        public Genre (string Genre)
        {

        }
        public void AddTitle(Title title)
        {
            
        }
        //public static Genre operator + (Genre genre1, Genre genre2)
        //{
        //    Genre romanticComedy = genre1.Comedy + genre2.Romance;
        //    return new Genre(romanticComedy);
        //}
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
