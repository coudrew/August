using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forForEach
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Dwarf[] dwarves = new Dwarf[7];
            dwarves[0] = new Dwarf("Doc", "roast beef", "english beer");
            dwarves[1] = new Dwarf("Sleepy", "Thai red curry", "coffee");
            dwarves[2] = new Dwarf("Grumpy", "ultra-rare steak", "children's tears");
            dwarves[3] = new Dwarf("Bashful", "just a few of someone else's chips", "Cocoa and absinthe");
            dwarves[4] = new Dwarf("Dopey", "candy and crisps", "hot iced tea");
            dwarves[5] = new Dwarf("Happy", "Spanikopita with organic, locally sourced spinach, and cruelty-free feta", "green tea or whatever");
            dwarves[6] = new Dwarf("Sneezy", "toad in the hole", "Mountain Dew");
            for (int i = 0; i < dwarves.Length; i++)
            {
                Console.WriteLine(dwarves[i].Name + ", your " + dwarves[i].Dinner + " is ready!");
            };
            foreach (Dwarf dwarf in dwarves)
            {
                Console.WriteLine("And here's a nice warm drink of " + dwarf.Drink + ", " + dwarf.Name);
            };
        }
    }
}
