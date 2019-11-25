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
        


        //member methods (can do)
        public int createTemperature()
        {
            temperature = rand.Next(60, 105);
            return temperature;
        }

        public string createWeatherConditions()
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
