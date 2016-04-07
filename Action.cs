using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    class Action : Genre 
    {
        public Action (string title, double rating):base(title, rating)
        {
            
        }
        public Action()
        { 
        }

        public void NameActionMovies()
        {
           Action django = new Action("Django Unchained", 5);
           Action scarface = new Action("Scarface", 5);
           Action hotfuzz = new Action("Hot Fuzz", 4.5);
           Action hellboy = new Action("Hellboy", 3);
           Action sincity = new Action("Sin City", 4);
           Action twothousand = new Action("2001, A Space Odyssey", 4);
            actionList.Add(scarface);
            actionList.Add(hotfuzz);
            actionList.Add(hellboy);
            actionList.Add(sincity);
            actionList.Add(twothousand);
            actionList.Add(django);
        }

    }
}
