using System;
using System.Collections.Generic;

namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numCommands = int.Parse(Console.ReadLine());

            var carRegister = new Dictionary<string, string>();

            for (int i = 0; i < numCommands; i++)
            {
                string[] command = Console.ReadLine().Split(' ');

                switch (command[0])
                {
                    case "register":
                        carRegister = RegisterCar(carRegister, command[1], command[2]);
                        break;
                    case "unregister":
                        carRegister = UnRegisterCar(carRegister, command[1]);
                        break;
                }
            }

            foreach (var user in carRegister)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }

        private static Dictionary<string, string> UnRegisterCar(Dictionary<string, string> carRegister, string username)
        {
            if (!carRegister.ContainsKey(username))
            {
                Console.WriteLine($"ERROR: user {username} not found");
                return carRegister;
            }

            carRegister.Remove(username);
            Console.WriteLine($"{username} unregistered successfully");
            return carRegister;
        }

        private static Dictionary<string, string> RegisterCar(Dictionary<string, string> carRegister, string username, string regNumber)
        {
            if (carRegister.ContainsKey(username))
            {
                Console.WriteLine($"ERROR: already registered with plate number {carRegister[username]}");
                return carRegister;
            }

            carRegister.Add(username, regNumber);
            Console.WriteLine($"{username} registered {regNumber} successfully");
            return carRegister;
        }
    }
}
