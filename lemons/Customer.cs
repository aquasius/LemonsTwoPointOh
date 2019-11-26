using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemons
{
    class Customer
    {
        //member variables (has a)
        List<string> names;
        public string name;
        public double chanceToBuy;
        public int customerToBuy;
        Random rnd = new Random();
        
        //constructor
        public Customer()
        {
            DetermineIfBuyLemonade();
            chanceToBuy = rnd.Next(1, 100);
            

        }

        //member methods (can do)
        public bool DetermineIfBuyLemonade(double priceOfLemonade, Weather weather)
        {
            int chanceToBuy = rnd.Next(1, 100);   
            if((weather.condition == "Sunny" && priceOfLemonade <= .27) && chanceToBuy <= 70)
            {
                return true;
            }
            
            else if((weather.condition == "Rainy" && priceOfLemonade <= .24) && chanceToBuy <= 40)
            {
                return true;
            }
            
            else if((weather.condition == "Scorching Hot" && priceOfLemonade <= .30) && chanceToBuy <= 65)
            {
                return true;
            }

            else if((weather.condition == "Cloudy" && priceOfLemonade <= .25) && chanceToBuy <= 60)
            {
                return true;
            }
            else if((weather.condition == "Humid" && priceOfLemonade <= .28) && chanceToBuy <= 72)
            {
                return true;
            }
            
            else if((weather.condition == "Storming" && priceOfLemonade <= .22) && chanceToBuy <= 30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
