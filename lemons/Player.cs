using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemons
{
    class Player
    {
       //member variables(has a)
        public string name;
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public Pitcher pitcher;
        public Store store;
        public int profitMoney;
        public int totalMoney;
        double startingMoney;
        //constructor
        public Player()
        {
            wallet = new Wallet();
            //recipe = new Recipe();
            inventory = new Inventory();
            
        }


        //member methods (can do)
        public void makeLemonade()
        {

        }

        

        public void SellLemonade()
        {



            double startingMoney = wallet.Money;


        }
    
        public void MakeProfit()
        {

        }
        public void MadeProfit()
        {
           if(wallet.Money > startingMoney)
           {
                Console.WriteLine("Congratulations! You made: " + player.MakeProfit);
           }
                
        }
    
        public void createRecipe(Inventory inventory)
        {
            Console.WriteLine("How many Lemons would you like to put into your recipe today?");
            int lemonsInPitcher = Convert.ToInt32(Console.ReadLine());
            if (lemonsInPitcher >= inventory.lemons.Count)
            {
                int lemonsLeftInInventory = inventory.lemons.Count - lemonsInPitcher;
                Console.WriteLine(lemonsInPitcher + ": lemons now equal 1 pitcher of lemonade.");
                Console.WriteLine("you currently have: " + lemonsLeftInInventory + " left");
            }

            Console.WriteLine("How many Sugar Cubes would you like to add to your recipe today?");
            int sugarCubesInPitcher = Convert.ToInt32(Console.ReadLine());
            if(sugarCubesInPitcher >= inventory.sugarCubes.Count)
            {
                int sugarCubesLeftInInventory = inventory.lemons.Count - sugarCubesInPitcher;
                Console.WriteLine(sugarCubesInPitcher + ": cubes of sugar now equal 1 pitcher of lemonade");
                Console.WriteLine("you currently have: " + sugarCubesLeftInInventory + " left");
            }
            Console.WriteLine("How many Ice Cubes would you like to put into your recipe today? ");
            int iceCubesInPitcher = Convert.ToInt32(Console.ReadLine()); 
            if(iceCubesInPitcher >= inventory.iceCubes.Count)
            {
                int iceCubesLeftInPitcher = inventory.iceCubes.Count - iceCubesInPitcher;
                Console.WriteLine(iceCubesInPitcher + ": ice cubes now equal 1 pitcher");

            }
        }
    
        public void goBankrupt()
        {
            if(wallet.Money <= 0)
            {
                Console.WriteLine("Oh no! you ran out of funds!");

            }
        }

        public void goToStorePrompt()
        {
            Console.WriteLine("Would you like to visit the store to buy more items?");
            string choice = Console.ReadLine().ToLower();

            switch(choice)
            {
                case "yes":
                    
            }
            
                //call display items function. Ask would you like to go to the store to buy more items? if yes 
           // display store. If no, generate new day.

        }
    
    
        public void RefillPitcher()
        {

        }
    
    }


}
