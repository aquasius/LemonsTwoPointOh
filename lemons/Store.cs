using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemons
{
    class Store
    {
        //member methods (has a)
        double pricePerLemon;
        double pricePerSugarCube;
        double pricePerIceCube;
        double pricePerCup;



        //constructor
        public Store()
        {
            pricePerLemon = .5;
            pricePerSugarCube = .1;
            pricePerIceCube = .01;
            pricePerCup = .25;

            
        }


        //member methods (can do)
        
        public void DisplayStore(Player player)
        {
            SellLemons(player);
            SellSugarCubes(player);
            SellIceCubes(player);
            SellCups(player);
        }
        
        public void SellLemonade()
        {

        }
        
        public void SellLemons(Player player)
        {
            int lemonsToPurchase = UserInterface.GetNumberOfItems("lemons");
            double transactionAmount = CalculateTransactionAmount(lemonsToPurchase, pricePerLemon);
            if(player.wallet.Money >= transactionAmount)
            {
                
                player.wallet.PayMoneyForItems(transactionAmount);
                player.inventory.AddLemonsToInventory(lemonsToPurchase);
            }

            else if (player.wallet.Money <= transactionAmount)
            {
                Console.WriteLine("You do not have enough to purchase this amount. Please enter an affordable amount");
                SellLemons(player);
            }

        }
    
        public void SellSugarCubes(Player player)
        {
            int sugarToPurchase = UserInterface.GetNumberOfItems("sugar");
            double transactionAmount = CalculateTransactionAmount(sugarToPurchase, pricePerSugarCube);
            if(player.wallet.Money >= transactionAmount)
            {
                PerformTransaction(player.wallet, transactionAmount);
                player.inventory.AddSugarCubesToInventory(sugarToPurchase);
            }

            else if(player.wallet.Money <= transactionAmount)
            {
                Console.WriteLine("You do not have enough to purchase this amount. Please enter an affordable amount");
                SellSugarCubes(player);
            }

        }

        public void SellIceCubes(Player player)
        {
            int iceCubesToPurchase = UserInterface.GetNumberOfItems("ice cubes");
            double transactionAmount = CalculateTransactionAmount(iceCubesToPurchase, pricePerIceCube);
            if (player.wallet.Money >= transactionAmount)
            {
                PerformTransaction(player.wallet, transactionAmount);
                player.inventory.AddIceCubesToInventory(iceCubesToPurchase);
            }

            else if (player.wallet.Money <= transactionAmount)
            {
                Console.WriteLine("You do not have enough to purchase this amount. Please enter an affordable amount");
                SellIceCubes(player);
            }

        }

        public void SellCups(Player player)
        {
            int cupsToPurchase = UserInterface.GetNumberOfItems("cups");
            double transactionAmount = CalculateTransactionAmount(cupsToPurchase, pricePerCup);
            if (player.wallet.Money >= transactionAmount)
            {
                PerformTransaction(player.wallet, transactionAmount);
                player.inventory.AddCupsToInventory(cupsToPurchase);
            }

            else if (player.wallet.Money <= transactionAmount)
            {
                Console.WriteLine("You do not have enough to purchase this amount. Please enter an affordable amount");
                SellCups(player);
            }

        }

        private double CalculateTransactionAmount(int itemCount, double itemPricePerUnit)
        {
            double transactionAmount = itemCount * itemPricePerUnit;
            return transactionAmount;
        }

        private void PerformTransaction(Wallet wallet, double transactionAmount)
        {
            wallet.PayMoneyForItems(transactionAmount);
        }

    }
}
