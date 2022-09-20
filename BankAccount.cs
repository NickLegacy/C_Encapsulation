using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulationExercise
{
    public class BankAccount
    {
        private double _balance;

        public void depost(double amount)
        {
            Console.WriteLine($"Deposit of {amount,0:c} to account");
            _balance = amount;
        }

        public double GetBalance()
        {
        return _balance;
        }



    }
}
