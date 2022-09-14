using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Snowwhite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dwarfs = new Dictionary<Dwarf, int>();

            string[] input = Console.ReadLine().Split(" <:> ");

            while (input[0] != "Once upon a time")
            {
                string name = input[0];
                string hatColor = input[1];
                int physics = int.Parse(input[2]);

                Dwarf curDwarf = new Dwarf(name, hatColor);

                if (!dwarfs.Keys.Any(dwarf => dwarf.Name == name && dwarf.HatColor == hatColor))
                {
                    dwarfs.Add(curDwarf, physics);
                }
                else 
                {
                    if (dwarfs.First(x => x.Key.Name == name && x.Key.HatColor == hatColor).Value < physics)
                    {
                        dwarfs.Remove(dwarfs.First(x => x.Key.Name == name && x.Key.HatColor == hatColor).Key);
                        dwarfs.Add(curDwarf, physics);
                    }
                }

                input = Console.ReadLine().Split(" <:> ");
            }
            
            foreach (var dwarf in dwarfs
                         .OrderByDescending(dwarf => dwarf.Value)
                         .ThenByDescending(dwarf => dwarfs.Count(d => d.Key.HatColor == dwarf.Key.HatColor)))
            {
                Console.WriteLine($"({dwarf.Key.HatColor}) {dwarf.Key.Name} <-> {dwarf.Value}");
            }
        }
    }

    class Dwarf
    {
        public Dwarf(string name, string hatColor)
        {
            this.Name = name;
            this.HatColor = hatColor;
        }
        public string Name { get; set; }
        public string HatColor { get; set; }
    }
}
