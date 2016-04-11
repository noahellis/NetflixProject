using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    class View
    {
        public Catalog getCatalog = new Catalog();
        ////        View
        ////-    Prints out the various Genres and their Titles
        public View()
        {
           
        }       

        public string ToString() 
        {
            string temp = "";
            for (int printIndex = 0; printIndex<getCatalog.Action.titleList.Count; printIndex ++)
            {
                temp += printIndex +'\n';
                Console.WriteLine(temp);
            }
            return temp;
        }
        
    }
}
