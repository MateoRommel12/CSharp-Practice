using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using AtmMachine;

namespace AtmMachine
{
    public class AddMoney
    {
        public static void AddAmount()
        {
            Console.Write("Enter your name: ");
            string? name = Console.ReadLine()?.Trim();
            
            Console.Write("Password: ");
            string? passwordInput = Console.ReadLine()?.Trim();

            Console.Write("Enter amount: ");
            string? amountInput = Console.ReadLine();
            
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(amountInput) || string.IsNullOrEmpty(passwordInput))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            if (int.TryParse(amountInput, out int deposit))
            {
                var machine = new Machine
                {
                    Id = MachineManager.nextId++,
                    Name = name,
                    Password = "" + passwordInput, 
                    Deposit = deposit,
                    Withraw = 0
                };

                MachineManager.machine.Add(machine);
                Console.WriteLine("Money deposit successfully!");
            }
            else
            {
                Console.WriteLine("Invalid amount format");
            }
        }
    }
}