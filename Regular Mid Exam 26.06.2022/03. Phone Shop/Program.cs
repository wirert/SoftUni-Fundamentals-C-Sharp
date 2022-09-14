using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Phone_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> phones = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string[] command = Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "Add":
                        AddPhone(command[1], phones);
                        break;
                    case "Remove":
                        RemovePhone(command[1], phones);
                        break;
                    case "Bonus phone":
                        BonusPhone(command[1], phones);
                        break;
                    case "Last":
                        Last(command[1], phones);
                        break;
                }

                command = Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine(string.Join(", ", phones));
        }

        private static void Last(string phone, List<string> phones)
        {
            if (!phones.Contains(phone)) return;

            phones.Remove(phone);
            phones.Add(phone);
        }

        private static void BonusPhone(string s, List<string> phones)
        {
            string[] models = s.Split(':');

            for (int i = 0; i < phones.Count; i++)
            {
                if (models[0] != phones[i]) continue;
                phones.Insert(i + 1, models[1]);
                return;
            }
        }

        private static void RemovePhone(string modelPhone, List<string> phones)
        {
            if (!phones.Contains(modelPhone)) return;
            phones.Remove(modelPhone);
        }

        private static void AddPhone(string modelPhone, List<string> phones)
        {
            if (phones.Contains(modelPhone)) return;
            phones.Add(modelPhone);
        }
    }
}
