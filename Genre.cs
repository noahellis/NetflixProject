using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    class Genre
    {
        
        List<Title> titleList = new List<Title>();
        public List<Action> actionList = new List<Action>();
        public List<Romance> romanceList = new List<Romance>();
        public List<Comedy> comedyList = new List<Comedy>();
        
        public Genre (string title, double rating)
        {

        }
        public Genre()
        {

        }
        public enum Genres
        {            
            All =0,
            Romance=1,
            Comedy=2,
            Action=4,
        }       
        public void PrintAction()
        {
            foreach (Action movie in actionList)
            {
                Console.WriteLine(movie);
            }
        }
        //public static Genre operator + (Genre Comedy, Genre Romance)
        //{
        //    Genre romCom = new Genre();
        //    romCom = Comedy.comedyList + Romance.romanceList;
        //    return romCom;
        //}
    }
}
