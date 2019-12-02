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
        int amountOfCupsInPitcher;
        Cup cup;
        int maxCupsInPitcher;
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
            this.cupsLeftInPitcher = 0;
            MakePitcher();
            FillPitcher();
        }
        //member methods (can do)
        
        public void MakePitcher()
        {
            maxCupsInPitcher = 15;   
        }
    
        public void FillPitcher()
        {
            amountOfCupsInPitcher = maxCupsInPitcher;
          
           
        }
    
    
    
    }



}
