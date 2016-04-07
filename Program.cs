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
            Action testAction = new Action();
            testAction.NameActionMovies();
            Genre testGenre = new Genre();
            testGenre.PrintAction();
            Console.ReadKey();
        }
    }
}
