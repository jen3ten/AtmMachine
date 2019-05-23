using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_TDD
{
    public class Atm
    {
        public int Balance { get; set; }

        public Atm()
        {
            Balance = 0;
        }

        public Atm(int startingBalance)
        {
            Balance = startingBalance;
        }

        public int CheckBalance()
        {
            return Balance;
        }

        public void Withdraw()
        {

        }
    }
}
