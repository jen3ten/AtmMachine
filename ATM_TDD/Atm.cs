using System;

namespace ATM_TDD
{
    public class Atm
    {

        public int Balance { get; set; }

        public Atm()
        {
            
        }

        public Atm(int startingBalance)
        {
            Balance = startingBalance;
        }

        public int CheckBalance()
        {
            Console.WriteLine($"You have ${Balance} in your account.");
            return Balance;
        }

        public void Withdraw()
        {
            int withdrawalAmount = 10;
            Balance -= withdrawalAmount;
            Console.WriteLine($"You withdrew ${withdrawalAmount} from your account.");
        }

        public void Deposit()
        {
            int depositAmount = 50;
            Balance += depositAmount;
            Console.WriteLine($"You deposited ${depositAmount} into your account.");
        }
    }
}