using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    class View
    {

        ////        View
        ////-    Prints out the various Genres and their Titles
        Genre getGenre = new Genre();
        public View()
        {
           
        }       

        public void PrintAction()
        {
            getGenre.TitleList.ForEach(Console.WriteLine);
        }
        
    }
}
