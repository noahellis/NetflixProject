using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    class TelevisionShow : Title
    {
        
        public TelevisionShow(string showName, double rating, int lengthInMinutes ):base(showName, rating)
        {
            List<Episode> episodeList = new List<Episode>();
        }
        public void InputNewShow()
        {

        }
        //public override double CalculateAverageRating()
        //{
        //    Title average = episodeList?[0];
        //    return base.CalculateAverageRating();
        //}
    }
}
