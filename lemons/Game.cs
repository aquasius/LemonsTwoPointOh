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
        // int totalDays;
        Day day;
        Store store;
        public Weather weather;

        // constructor
        public Game()
        {
            
            // runGame();
        }

        // I left figuring out where to put my list of days.
        //member methods (can do)
        public void runGame()
        {

            DisplayRules();
            int totalDays = AmountOfDaysPrompt();
            CreateDay(totalDays);
            // while customers = 0 || EndDay();
            //display weather temp, forecast, starting money total 
            // display store
            
            for(int i = 0; i < days.Count; i++)
            {
                
                    
                days[i].RunDay();
                Console.WriteLine(days[i].weather.condition);



            }




        }

        public void CreateDay(int totalDays)
        {
            
            days = new List<Day>(); 
            for (int i = 0; i < totalDays; i++)
            {
               days.Add(new Day());
            }
            //weather.CreateWeatherConditions();
            //weather.CreateTemperature();
            
        }

        public void EndDay()
        {
            player.MakeProfit();
            day.DisplayProfit();
        }
        public void DisplayRules()
        {
            Console.WriteLine("You will be tasked with running a Lemonade Stand.\n Your goal is to create a MONEY MAKING recipe!\n Take into account the weather each day, as the weather will affect the amount of customers, as well as the amount of customers that will purchase your lemonade.\n Make as much as you can within the amount of days you choose!");
        }

        public int AmountOfDaysPrompt()
        {
            Console.WriteLine("How many days would you like to play for? 7 or 14");
            int totalDays = Convert.ToInt32(Console.ReadLine());
            return totalDays;
        }

    }
}
