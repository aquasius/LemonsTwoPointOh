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

        //constructor
        public Player()
        {
            wallet = new Wallet();
            recipe = new Recipe();
            inventory = new Inventory();

        }


        //member methods (can do)
        public void makeLemonade()
        {

        }

        public void sellLemonade()
        {

        }
    
        public void makeProfit()
        {
            if(totalMoney > startDayMoney)
            {
                Console.WriteLine("Congratulations! You made " + days.profit);
            }
        }
    
        public void createRecipe()
        {

        }
    
        public void goBankrupt()
        {
            if(totalMoney <= 0)
            {
                Console.WriteLine("Oh no! you ran out of funds!");

            }
        }

        public void goToStore()
        {
           //call display items function. Ask would you like to go to the store to buy more items? if yes 
           // display store. If no, generate new day.

        }
    }
}
