using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    class TelevisionShow : Title
    {
        public List<Episode> episodeList = new List<Episode>();
        public string showName;
        public int totalEpisodes;      
        public double ratingAverageHolder;
        public double averageRating;
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
            string show = String.Format("The title of the show is {0} and there are {1} episodes", showName, totalEpisodes);
            Console.WriteLine(show);
            return show;
        }

    }
}
