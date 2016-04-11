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
        public List<List<Episode>> seasonList = new List<List<Episode>>();
        public int numberOfSeasons { get; set; }
        public int numberOfEpisodes { get; set; }
        public int totalEpisodes; 
        public string ShowName { get; set; }
        public int LenghtInMinutes { get; set; }
        public TelevisionShow(string showName, double rating, int lengthInMinutes ):base(showName, rating,lengthInMinutes)
        {
            lengthInMinutes = LenghtInMinutes;
            showName = ShowName;
            totalEpisodes = numberOfEpisodes * numberOfSeasons;
        }
        public TelevisionShow()
        {

        }
        public override string ToString()
        {
            return "Television Show Info:" + ShowName +" " + totalEpisodes;
        }
        public void CreateSeasonList(int numberOfEpisodes, int numberOfSeasons)
        {
            for (int seasonIndex = 0; seasonIndex <= numberOfSeasons; seasonIndex++)
            {
                List<Episode> episodeList = new List<Episode>();
                for (int episodeIndex = 0; episodeIndex <= numberOfEpisodes; episodeIndex++)
                {                                       
                     episodeList.Add(new Episode());                    
                }
                seasonList.Add(episodeList);
            }
        }

    }
}
