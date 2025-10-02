using System;
using System.Collections.Generic;
using System.Linq;
using AtmMachine;

namespace AtmMachine
{
    public class viewBalance
    {
        public static void ViewBalance()
        {
            Console.Write("Enter name: ");
            string? nameInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nameInput))
            {
                Console.WriteLine("No name entered");
                return;
            }

            var customer = MachineManager.machine
                .FirstOrDefault(s => s.Name.Equals(nameInput, StringComparison.OrdinalIgnoreCase));

            if (customer == null)
            {
                Console.WriteLine("Name not found");
                return;
            }

            if (customer.Deposit == 0)
            {
                Console.WriteLine("No balance available");
                return;
            }

            Console.WriteLine($"Name: {customer.Name}, Balance: {customer.Deposit}");
        }
    }
}