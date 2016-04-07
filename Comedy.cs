using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    class Comedy : Genre
    {
        public Comedy(string name, double rating):base(name, rating)
        {

        }
        public Comedy()
        {

        }
        public void AddToComedyList()
        {
            Comedy rascals = new Comedy("The Little Rascals", 4.5);
            Comedy louis = new Comedy("Louis C.K.: Chewed Up", 4.5);
            Comedy pirates = new Comedy("Pirates of the Caribbean: The Curse of the Black Pearl", 4);
            Comedy talladega = new Comedy("Talladega Nights: The Ballad of Ricky Bobby", 3);
            Comedy team = new Comedy("Team America: World Police", 3.5);
            Comedy half = new Comedy("HalfBaked", 4);
            comedyList.Add(rascals);
            comedyList.Add(louis);
            comedyList.Add(pirates);
            comedyList.Add(talladega);
            comedyList.Add(team);
            comedyList.Add(half);

        }
    }
}
