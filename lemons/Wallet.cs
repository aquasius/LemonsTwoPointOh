using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemons
{
    class Wallet
    {
        //member variables(has a)
        private double money;

        public double Money
        {
            get
            {
                return money;
            }
        }


        //constructor
        public Wallet()
        {
            money = 20.00;
        }

        //member methods (can do)
        public void PayMoneyForItems(double transactionAmount)
        {
            money -= transactionAmount;
        }

        public void AddMoneyToWallet(double saleAmount)
        {
            money += saleAmount;
        }

        


    }
}
