using System;
using System.Collections.Generic;
using System.Linq;
using AtmMachine;
using static AtmMachine.AddMoney;
using static AtmMachine.viewBalance;
using static AtmMachine.Withdrawal;      

namespace AtmMachine
{
    class AtmDetails
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Welcome to ATM Machine");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("1. Deposit Amount");
                Console.WriteLine("2. Check Balance");
                Console.WriteLine("3. Withdraw Amount");
                Console.WriteLine("4. Exit");

                Console.Write("Choose: ");
                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddAmount();
                        break;
                    case "2":
                        ViewBalance();
                        break;
                    case "3":
                        Withdraw();
                        break;
                    case "4":
                        Console.WriteLine("Thank You for Visiting!");
                        return;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            }
        }

    }
}