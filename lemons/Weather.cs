using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemons
{
    public class Weather
    {
        //member variables (has a)
        public string condition;
        public int temperature;
        public string[] weatherConditions;
        Random rand;

        //constructor
        
        
        public Weather()
        {
            rand = new Random();
            CreateWeatherConditions();
            CreateTemperature();
        }


        //member methods (can do)
        public int CreateTemperature()
        {
            if(condition == "Sunny")
            {
                temperature = rand.Next(60, 80);
            }

            else if(condition == "Rainy")
            {
                temperature = rand.Next(45, 70);
            }

            else if(condition == "Scorching Hot")
            {
                temperature = rand.Next(90, 105);
            }
            
            else if(condition == "Cloudy")
            {
                temperature = rand.Next(50, 70);
            }

            else if(condition == "Humid")
            {
                temperature = rand.Next(75, 100);
            }

            else if(condition == "Storming")
            {
                temperature = rand.Next(45, 70);
            }

            else if(condition == "Windy")
            {
                temperature = rand.Next(55, 65);
            }
            temperature = rand.Next(40, 105);
            return temperature;
        }

        public string CreateWeatherConditions()
        {
            weatherConditions = new string[7];
            weatherConditions[0] = "Sunny" ;
            weatherConditions[1] = "Rainy";
            weatherConditions[2] = "Scorching Hot";
            weatherConditions[3] = "Cloudy";
            weatherConditions[4] = "Humid";
            weatherConditions[5] = "Storming";
            weatherConditions[6] = "Windy";
            int randomizeCondition = rand.Next(weatherConditions.Length);
            condition = weatherConditions[randomizeCondition];
            return condition;
        }
    }
}
