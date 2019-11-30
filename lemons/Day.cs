﻿using System;
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
            GenerateWeather();
        }


        //member methods(can do)
        public void RunDay()
        {
            CreateCustomer();
            GenerateCustomers();

        }
        public void GenerateWeather()
        {
            weather = new Weather();
        }
        
        public void GenerateCustomers()
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
                customers.Add(new Customer());
            }

        }


        

        
    }
}
