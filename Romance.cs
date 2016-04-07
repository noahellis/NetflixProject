using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    class Romance : Genre 
    {
        public Romance(string name, double rating):base(name, rating)
        {

        }
        public Romance()
        {

        }
        public void AddToRomanceList()
        {
            Romance silverlinings = new Romance("Silver Linings Playbook", 4.5);
            Romance grease = new Romance("Grease", 2.5);
            Romance something = new Romance("Something's Gotta Give", 2.5);
            Romance theswitch = new Romance("The Switch", 3);
            Romance sayit = new Romance("Say it isn't So", 2);
            Romance seeking = new Romance("Seeking a Friend for the End of the World", 4);
            romanceList.Add(silverlinings);
            romanceList.Add(grease);
            romanceList.Add(something);
            romanceList.Add(theswitch);
            romanceList.Add(sayit);
            romanceList.Add(seeking);

        }
    }
}
