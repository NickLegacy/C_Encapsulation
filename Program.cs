using System;

namespace BankEncapsulationExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
          BankAccount ba = new BankAccount();

            Console.WriteLine("How much would you like to deposit?");

            double amountToDeposit = double.Parse(Console.ReadLine());

            ba.depost(amountToDeposit);
            double userBalance = ba.GetBalance();

            Console.WriteLine($"Your current balance is: {userBalance, 0:c}");
        }
    }
}
