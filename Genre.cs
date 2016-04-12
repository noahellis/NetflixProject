using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    class Genre:IEnumerable
    {
        ////        Genre
        ////-    Contains a list of Titles+
        ////-    Implement custom iterator to iterate over those Titles+
        ////-    Overload plus(+) operator to take in two Genres and return the aggregated Genre.
        ////o For example, if we want to create an aggregated genre Romantic Comedy, all the film titles in that specific genre would include film titles from Romance and film titles from Comedy.
        ////-    Overload plus (+) operator to take in a Genre and a Title to return the aggregated Genre.
        ////o Take in a title, add it to the genre, return an aggregated list.
        ////o For example, title Die Hard and genre Comedy would return a list of all comedy films and Die Hard.
        ////-Create the genres: All, Romance, Action, Comedy.They need to share some titles(such as Romantic Comedies)
        ////by reference, not by duplicating the title itself.
        List<Title> titleList = new List<Title>();
        
        public string genreType;
        public Genre mixedGenre;
        public Genre genre1;
        public Genre genre2;

        public List<Title> TitleList
        {
            get
            {
                return titleList;
            }
            set
            {
                titleList = value;
            }
        }
        public Genre (string Genre)
        {

        }
        public Genre()
        {
            
        }
        public static Genre operator +(Genre genre1, Genre genre2)
        {
            Genre aggregatedGenre = new Genre();
            return aggregatedGenre;
        }
        public IEnumerator GetEnumerator()
        {
            for(int titleIndex = 0; titleIndex <titleList.Count; titleIndex++)
            {
                yield return titleList[titleIndex];
                
            }
            yield return "End of List";
        }

    }
}
