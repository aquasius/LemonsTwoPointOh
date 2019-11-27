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
    
       
        public void MadeProfit()
        {
           if(wallet.Money > startingMoney)
           {
                double makeProfit = wallet.Money - startingMoney;
                Console.WriteLine("Congratulations! You made: " + makeProfit);
           }
                
        }

        public void SetPrice()
        {
            
        }
    
        public double createRecipe(Inventory inventory)
        {
            Console.WriteLine("What would you like to set your price per cup of lemonade to?");
            double lemonadePrice = Convert.ToInt32(Console.ReadLine());
            //todo create methods
            
            Console.WriteLine("How many Lemons would you like to put into your recipe today?");
                recipe.lemonsInPitcher = Convert.ToInt32(Console.ReadLine());
            if (recipe.lemonsInPitcher >= inventory.lemons.Count)
            {
                int lemonsLeftInInventory = inventory.lemons.Count - recipe.lemonsInPitcher;
                Console.WriteLine(recipe.lemonsInPitcher + ": lemons now equal 1 pitcher of lemonade.");
                Console.WriteLine("you currently have: " + lemonsLeftInInventory + " left");
            }

            Console.WriteLine("How many Sugar Cubes would you like to add to your recipe today?");
               recipe.sugarCubesInPitcher = Convert.ToInt32(Console.ReadLine());
            if(recipe.sugarCubesInPitcher >= inventory.sugarCubes.Count)
            {
                int sugarCubesLeftInInventory = inventory.lemons.Count - recipe.sugarCubesInPitcher;
                Console.WriteLine(recipe.sugarCubesInPitcher + ": cubes of sugar now equal 1 pitcher of lemonade");
                Console.WriteLine("you currently have: " + sugarCubesLeftInInventory + " left");
            }
            Console.WriteLine("How many Ice Cubes would you like to put into your recipe today? ");
              recipe.iceCubesInPitcher = Convert.ToInt32(Console.ReadLine()); 
            if(recipe.iceCubesInPitcher >= inventory.iceCubes.Count)
            {
                int iceCubesLeftInPitcher = inventory.iceCubes.Count - recipe.iceCubesInPitcher;
                Console.WriteLine(recipe.iceCubesInPitcher + ": ice cubes now equal 1 pitcher");

            }
            return lemonadePrice;
        }
    
        public void goBankrupt()
        {
            if(wallet.Money <= 0)
            {
                Console.WriteLine("Oh no! you ran out of funds!");

            }
        }

        
    
    
        
    
    }


}
