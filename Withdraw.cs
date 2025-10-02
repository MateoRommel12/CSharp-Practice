using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using AtmMachine;

namespace AtmMachine
{
    public class Withdrawal
    {
        public static void Withdraw()
        {
            Console.Write("Enter name: ");
            string? nameInput = Console.ReadLine();

            Console.Write("Password: ");
            string? passwordInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nameInput) || string.IsNullOrWhiteSpace(passwordInput))
            {
                Console.WriteLine("No name entered or Password");
                return;
                
            }

            var customer = MachineManager.machine
                .FirstOrDefault(s => s.Name.Equals(nameInput, StringComparison.OrdinalIgnoreCase) && s.Password.Equals(passwordInput, StringComparison.OrdinalIgnoreCase));

            if (customer == null)
            {
                Console.WriteLine("Incorrect Name or Password");
                return;
            }

            if (customer.Deposit == 0)
                {
                    Console.WriteLine("No balance available");
                    return;
                }

            Console.Write("Enter amount to withdraw: ");
            string? amountInput = Console.ReadLine();

            if (string.IsNullOrEmpty(amountInput))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            if (int.TryParse(amountInput, out int withdrawAmount))
            {
                if (withdrawAmount > customer.Deposit)
                {
                    Console.WriteLine("Insufficient balance");
                    return;
                }

                customer.Deposit -= withdrawAmount;
                customer.Withraw += withdrawAmount;

                Console.WriteLine("Withdrawal successful!");
                Console.WriteLine($"Remaining Balance: {customer.Deposit}");
            }
            else
            {
                Console.WriteLine("Invalid amount format");
            }
        }
    }
}