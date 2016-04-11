using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    class TelevisionShow : Title
    {
        ////        Show(inherits from Title)
        ////-    Contains a list of Episodes
        ////-    Overrides parent’s Rating to return an aggregated rating of Episode ratings
        ////-    Overrides ToString() method to return a string of the name of the show and number of episodes
        //public List<Episode> seasonList = new List<Episode>();
        public List<Episode> episodeList = new List<Episode>();
        
        public int numberOfEpisodes; 
        public int totalEpisodes;
        public string showName;
        public int lenghtInMinutes;
        public double rating;
        public double ratingAverageHolder;
        public double averageRating;
        public double randomRating;
        public TelevisionShow(string ShowName, double Rating, int LengthInMinutes, int TotalEpisodes):base(ShowName, Rating, LengthInMinutes)
        {
            lenghtInMinutes = LengthInMinutes;
            showName = ShowName;
            rating = Rating;
            totalEpisodes = TotalEpisodes;
            
        }
        public TelevisionShow()
        {

        }
        public double AggrigateEpisodeRating()
        {

            for (int episodeIndex = 0; episodeIndex < totalEpisodes; episodeIndex++)
            {
                Random randomRating = new Random();                
                ratingAverageHolder += randomRating.Next(1, 6);
            }
            averageRating = ratingAverageHolder / totalEpisodes;
            return averageRating;
        }
        public override string ToString()
        {
            
            return "Television Show Info: " + showName +" " + totalEpisodes + " total episodes";
        }
        //public void CreateSeasonList(int numberOfEpisodes, int numberOfSeasons)
        //{
        //    for (int seasonIndex = 0; seasonIndex < numberOfSeasons; seasonIndex++)
        //    {
        //        List<Episode> episodeList = new List<Episode>();
        //        for (int episodeIndex = 0; episodeIndex < numberOfEpisodes; episodeIndex++)
        //        {                                       
        //             episodeList.Add(new Episode());                    
        //        }
        //        seasonList.Add(episodeList);
        //    }
            
        //}

    }
}
