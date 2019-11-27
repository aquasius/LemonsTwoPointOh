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
        int currentDay; // TODO : make currentdays ++
        // int totalDays;
       
        Store store;
      

        // constructor
        public Game()
        {
            player = new Player();
            store = new Store();
            // runGame();
        }

        // I left figuring out where to put my list of days.
        //member methods (can do)
        public void runGame()
        {

            DisplayRules();
            int totalDays = AmountOfDaysPrompt();
            CreateDay(totalDays);
            
            
            for(int i = 0; i < days.Count; i++)
            {
                // display money amount
                // go to store
                goToStorePrompt();
                Console.WriteLine(player.wallet.Money);
                
                    
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
            
        }

        public void SellLemonade()
        {
            double lemonadePrice = player.createRecipe(player.inventory);

            double startingMoney = player.wallet.Money;
            //TODO: implement MakePitcher()
            player.pitcher.MakePitcher();

            for (int i = 0; i < days[currentDay].dayCustomers; i++)
            {
                bool decisionToBuyLemonade = days[currentDay].customers[i].DetermineIfBuyLemonade(lemonadePrice, days[currentDay].weather);
                if( decisionToBuyLemonade == true)
                {
                    player.wallet.AddMoneyToWallet(lemonadePrice);
                }
            }
            

        
        
        }

        public void goToStorePrompt()
        {
            Console.WriteLine("Would you like to visit the store to buy more items?");
            string choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case "yes":
                    store.DisplayStore(player);
                    break;

                case "no":
                    // TODO: display inventory
                    // reminder: player.inventory.lemons.Count
                    break;

            }

            //call display items function. Ask would you like to go to the store to buy more items? if yes 
            // display store. If no, generate new day.

        }

        public void RefillLemonade()
        {
            if(player.pitcher.CupsLeftInPitcher == 0)
            {
                player.pitcher.FillPitcher();
            }
        }


        public void EndDay()
        {
            //if (day.dayCustomers == 0)
            //{
            //    player.MakeProfit();
            //    day.DisplayProfit();
            //}
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

        public void SetLemonadeCupPrice()
        {
            Console.WriteLine("");
        }

    }
}
