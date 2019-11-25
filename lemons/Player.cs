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

    }
}
