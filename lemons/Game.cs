using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemons
{
    class Game
    {
        //member variables( has a )
        Player player;
        List<Day> days;
        int currentDay;
        Day day;


        // constructor



        //member methods (can do)
        public void runGame()
        {
           
        }

        public List<Day> createDay()
        {
            days = new List<Day>; 
            for (int i = 1; i < totalDays; i++)
            {
               days.Add(new Day());
            }
            return days;
        }

    }
}
