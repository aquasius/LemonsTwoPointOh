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
        
       
        Store store;
      

        // constructor
        public Game()
        {
            currentDay = 0;
            player = new Player();
            store = new Store();
           
        }

        
        //member methods (can do)
        public void runGame()
        {

            DisplayRules();
            int totalDays = AmountOfDaysPrompt();
            CreateDay(totalDays);
            Console.ReadLine();
            
            for(int i = 0; i < days.Count; i++)
            {
                DisplayUsersMoney();
                Console.WriteLine(player.wallet.Money);
                GoToStorePrompt();
                Console.WriteLine("Your day is starting with " + player.inventory.lemons.Count + " lemons.");
                Console.WriteLine("You have " + player.inventory.sugarCubes.Count + " sugar cubes in your inventory.");
                Console.WriteLine("You have " + player.inventory.iceCubes.Count + " ice cubes.");
                Console.WriteLine("Wallet: " + player.wallet.Money);
                
                days[i].RunDay();
                Console.WriteLine("Today's weather is: " + days[i].weather.condition);
                SellLemonade();
                RefillPitcherOfLemonade();
                

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

        public void DisplayUsersMoney()
        {
            Console.WriteLine("Wallet: " + player.wallet.Money);
        }

        public double SellLemonade()
        {
            double salePriceOfLemonade = player.SetPrice();
            double startingMoney = player.wallet.Money;
            player.pitcher.MakePitcher();

            for (int i = 0; i < days[currentDay].dayCustomers; i++)
            {
                bool decisionToBuyLemonade = days[currentDay].customers[i].DetermineIfBuyLemonade(salePriceOfLemonade, days[currentDay].weather);
                if( decisionToBuyLemonade == true)
                {
                    player.wallet.AddMoneyToWallet(salePriceOfLemonade);
                }
            }
            

            return salePriceOfLemonade;
        
        }

        public void GoToStorePrompt()
        {
            Console.WriteLine("Would you like to visit the store to buy more items?");
            string choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case "yes":
                    store.DisplayStore(player);
                    break;

                case "no":
                    Console.WriteLine("You currently have " + player.inventory.lemons.Count + " in your inventory.");
                    Console.WriteLine("There are currently " + player.inventory.sugarCubes.Count + " remaining in your inventory");
                    Console.WriteLine("You have " + player.inventory.iceCubes.Count + "ice cubes");
                    Console.WriteLine("You have " + player.inventory.cups.Count + " in your inventory");
                    break;

            }

            //call display items function. Ask would you like to go to the store to buy more items? if yes 
            // display store. If no, generate new day.

        }

        public void RefillPitcherOfLemonade()
        {
            if(player.pitcher.CupsLeftInPitcher == 0)
            {
                player.pitcher.FillPitcher();
                player.inventory.lemons.RemoveRange(0, player.recipe.lemonsInPitcher);
                player.inventory.sugarCubes.RemoveRange(0, player.recipe.sugarCubesInPitcher);
                player.inventory.iceCubes.RemoveRange(0, player.recipe.iceCubesInPitcher);
            }
        
            else if((player.inventory.lemons.Count < player.recipe.lemonsInPitcher) && player.inventory.sugarCubes.Count < player.recipe.sugarCubesInPitcher && player.inventory.iceCubes.Count < player.recipe.iceCubesInPitcher)
            {
                Console.WriteLine("You have an insufficient amount of items to make another pitcher. The day has ended");
                EndDay();
            }
        
        }


        public void EndDay()
        {
            double amountOfProfit = player.wallet.Money - player.startingMoney;


            if (days[currentDay].dayCustomers == 0)
            {
                Console.WriteLine("Today you made a total of: " + amountOfProfit);
                currentDay++;
            }
            
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
