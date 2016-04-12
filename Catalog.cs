using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    class Catalog
    {
        List<Genre> genres;
        public Genre Comedy = new Genre("Comedy");
        public Genre Romance = new Genre("Romance");
        public Genre Action = new Genre("Action");
        public Genre All = new Genre("All");
        public Catalog()
        {
            AddRomanceMovie();
            AddComedyMovie();
            AddActionMovie();
        }
        public void AddComedyMovie()
        {
            Movie rascals = new Movie("The Little Rascals", 4.5, 82);
            Movie louis = new Movie("Louis C.K.: Chewed Up", 4.5, 71);
            Movie pirates = new Movie("Pirates of the Carribean: The Curse of the Black Pearl", 4, 143);
            Movie talladega = new Movie("Talladega Nights: The Ballad of Ricky Bobby", 3, 108);
            Movie america = new Movie("Team America: World Police", 3.5, 99);
            Movie half = new Movie("Half Baked", 4, 82);
            Action.TitleList.Add(rascals);
            Action.TitleList.Add(louis);
            Action.TitleList.Add(pirates);
            Action.TitleList.Add(talladega);
            Action.TitleList.Add(america);
            Action.TitleList.Add(half);
            All.TitleList.Add(rascals);
            All.TitleList.Add(louis);
            All.TitleList.Add(pirates);
            All.TitleList.Add(talladega);
            All.TitleList.Add(america);
            All.TitleList.Add(half);

        }
        public void AddRomanceMovie()
        {
            Movie silver = new Movie("Silver Linings Playbook", 4.5, 122);
            Movie grease = new Movie("Grease", 2.5, 110);
            Movie something = new Movie("Something's Gotta Give", 2.5, 128);
            Movie theSwitch = new Movie("The Switch", 3, 101);
            Movie say = new Movie("Say it isn't So", 2, 95);
            Movie end = new Movie("Seeking a Friend for the End of the World", 4, 101);
            Action.TitleList.Add(silver);
            Action.TitleList.Add(grease);
            Action.TitleList.Add(something);
            Action.TitleList.Add(theSwitch);
            Action.TitleList.Add(say);
            Action.TitleList.Add(end);
            All.TitleList.Add(silver);
            All.TitleList.Add(grease);
            All.TitleList.Add(something);
            All.TitleList.Add(theSwitch);
            All.TitleList.Add(say);
            All.TitleList.Add(end);
        }
        public void AddActionMovie()
        {
            Movie django = new Movie("Django Unchained", 5, 265);
            Movie scarface = new Movie("Scarface", 5, 170);
            Movie hotFuzz = new Movie("Hot Fuzz", 4.5, 121);
            Movie hellboy = new Movie("Hellboy", 3, 132);
            Movie sinCity = new Movie("Sin City", 4, 147);
            Movie spaceOdyssey = new Movie("2001: A Space Odyssey", 4, 161);
            Action.TitleList.Add(django);
            Action.TitleList.Add(scarface);
            Action.TitleList.Add(hotFuzz);
            Action.TitleList.Add(hellboy);
            Action.TitleList.Add(sinCity);
            Action.TitleList.Add(spaceOdyssey);
            All.TitleList.Add(django);
            All.TitleList.Add(scarface);
            All.TitleList.Add(hotFuzz);
            All.TitleList.Add(hellboy);
            All.TitleList.Add(sinCity);
            All.TitleList.Add(spaceOdyssey);
        }
    }
}
