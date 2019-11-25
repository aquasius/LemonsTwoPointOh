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
        int totalDays;
        Day day;
        public Weather weather;

        // constructor



        //member methods (can do)
        public void runGame()
        {
            createDay();
            //display weather temp, forecast, starting money total 
            // display store
            





        }

        public List<Day> CreateDay()
        {
            days = new List<Day>(); 
            for (int i = 1; i < totalDays; i++)
            {
               days.Add(new Day());
            }
            return days;
        }

    }
}
