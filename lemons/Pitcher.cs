using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemons
{
    class Pitcher
    {
        //member variables(has a)
        public int amountOfCupsInPitcher;
        Cup cup;
        public int maxCupsInPitcher;
        int cupsLeftInPitcher;
        public int CupsLeftInPitcher
        {
            get
            {
                return cupsLeftInPitcher;
            }
            
            set
            {
                cupsLeftInPitcher = 0;
            }
        }


        //constructor
        public Pitcher()
        {
            this.amountOfCupsInPitcher = 15;
            //this.cupsLeftInPitcher = 0;
            this.maxCupsInPitcher = 15;
            
            
        }
        //member methods (can do)
        
        //public void MakePitcher()
        //{
        //    maxCupsInPitcher = 15;
           

        //}
    
        
    
    
    
    }



}
