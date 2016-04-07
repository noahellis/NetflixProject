using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    class View
    {
        Title viewTitle = new Title();
        public string ChoosePrintGenre()
        {
            string printGenreChoice;
            Console.WriteLine("Enter the genre you would like to print\nEnter 1 for Comedy, Enter 2 for Romance, Enter 3 for Action");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    printGenreChoice = "comedy";
                    return printGenreChoice;
                case 2:
                    printGenreChoice = "romance";
                    return printGenreChoice;
                case 3:
                    printGenreChoice = "action";
                    return printGenreChoice;               
                default:
                    Console.WriteLine("Incorrect Input. Try again");
                    return ChoosePrintGenre();                                     
            }            
        }
        public void PrintComedy()
        {
            
        }
    }      
}
