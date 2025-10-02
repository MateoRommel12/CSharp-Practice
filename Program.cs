using System;

namespace AtmMachine
{
    public class Machine
    {
        public int Id { get; set; }
        public required string Name { get; set; } = "";
        public required string Password { get; set; } = "";
        public double Deposit { get; set; }
        public double Withraw { get; set; }
    }

    public static class MachineManager
    {
        public static List<Machine> machine = new List<Machine>();
        public static int nextId = 1;
    }
}
