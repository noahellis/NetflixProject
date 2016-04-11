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
            TelevisionShow testShow = new TelevisionShow { ShowName = "30 Rock", rating = 5,};
            testShow.CreateSeasonList(22,10);
            //View testView = new View();
            //testView.ChoosePrintGenre();
            Console.WriteLine(testShow);
            Console.ReadKey();
        }
    }
}
