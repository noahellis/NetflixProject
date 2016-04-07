using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    class Title 
    {
        public double averageShowRating;
        public Title()
        {

        }
        public Title(string showName, double newShowRating)
        {

        }
        public virtual double CalculateAverageRating()
        {
             
            return averageShowRating;
        }
        
    }
}
