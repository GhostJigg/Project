using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class BankAccount
    {
        public string CustomerName { get; set; }
        public int AccountNumber { get; set; }
        public double Balance { get; set; }

        public BankAccount(int accNo)
        {
            if (accNo==0)
            {
                accNo = 1000 + 1;

            }


            
        }

        public void Deposit (int amount)
        {

        }
    }
}
