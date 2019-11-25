using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemons
{
    class Day
    {
        //member variables(has a)
        public Weather weather;
        public int profit;
        public string recipe;
        public int dayTemp;
        public double dayCustomers;
        Player player;



        //constructor

        public Day()
        {
            generateWeather();
        }


        //member methods(can do)
        public void RunDay()
        {

        }
        public void generateWeather()
        {
            weather = new Weather();
        }
        
        public void generateCustomers()
        {

        }


        public int DisplayProfit(int )
        {
            Console.WriteLine("Your profit for the day is: " + player.MakeProfit());
        }

        public void createRecipe()
        { 
        }
    }
}
