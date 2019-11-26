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
        public List<Customer> customers;


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
            if(weather.condition == "Sunny")
            {
                dayCustomers = 120;
            }

            else if(weather.condition == "Rainy")
            {
                dayCustomers = 40;
            }

            else if(weather.condition == "Scorching Hot")
            {
                dayCustomers = 100;
            }
        
            else if(weather.condition == "Cloudy")
            {
                dayCustomers = 60;
            }
        
            else if(weather.condition == "Humid")
            {
                dayCustomers = 80;
            }
        
            else if(weather.condition == "Storming")
            {
                dayCustomers = 20;
            }
        
        }

        public void CreateCustomer()
        {

            customers = new List<Customer>();
            for (int i = 0; i < dayCustomers; i++)
            {
                customers.Add(new Customer(customers));
            }

        }


        public int DisplayProfit()
        {
            //Console.WriteLine("Your profit for the day is: " + player.MakeProfit());
            return 0;
        }

        public void createRecipe()
        { 
        }
    }
}
