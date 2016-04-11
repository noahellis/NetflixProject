using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //TelevisionShow testShow = new TelevisionShow("30 Rock", 3, 22, 20);
            //testShow.AggrigateEpisodeRating();
            //Movie movie = new Movie();
            //movie.AddActionMovie();
            //View testView = new View();
            //testView.AddActionMovie();
            //testView.DisplayAction();
            //testView.ChoosePrintGenre();
            //Console.WriteLine(testShow);
            Catalog testCatalog = new Catalog();
            testCatalog.AddActionMovie();
            testCatalog.AddComedyMovie();
            testCatalog.AddRomanceMovie();
            View testView = new View();
            testView.ToString();

            Console.ReadKey();
        }
    }
}
