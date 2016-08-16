using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresDictionary
{
    class Program
    {
        public static Dictionary<string, string> gearList = new Dictionary<string, string>();
        public static bool running = true;
        static void Main(string[] args)
        {
            while (running == true)
            {
                Console.WriteLine("\n Please choose an action: \n 'a' to add to the gear list \n 'r' to remove from gear list \n 'e' to edit item in gear list \n 's' to show gear list \n 'q' to quit");
                string action = Console.ReadLine();

                switch (action)
                {
                    case "a":
                        Add();
                        break;
                    case "r":
                        Remove();
                        break;
                    case "e":
                        Edit();
                        break;
                    case "s":
                        Show();
                        break;
                    case "q":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid action");
                        break;

                }
            }
        }

        public static void Add()
        {
            Console.Clear();
            Console.WriteLine("Enter equipment name/model #: ");
            string key = Console.ReadLine();
            Console.WriteLine("Enter description of equipment: ");
            string value = Console.ReadLine();
            gearList.Add(key, value);
        }

        public static void Remove()
        {
            Console.Clear();
            Console.WriteLine("Enter name/model # to remove: ");
            string searchKey = Console.ReadLine();
            foreach (KeyValuePair<string, string> gear in gearList)
            {
                if (gear.Key == searchKey)
                {
                    gearList.Remove(gear.Key);
                    Console.WriteLine(gear.Key + " removed");
                    return;
                }
            }
            Console.WriteLine("\n Not found");
        }

        public static void Edit()
        {
            Show();
            Console.WriteLine("Enter name/model # to edit:");
            string searchKey = Console.ReadLine();
            foreach (KeyValuePair<string, string> gear in gearList)
            {
                if (gear.Key == searchKey)
                {
                    Console.WriteLine("\nFound: " + gear.Key + " " + gear.Value);
                    Console.WriteLine("\nEnter new model #:");
                    string newModel = Console.ReadLine();
                    if (newModel.Length < 1)
                    {
                        newModel = gear.Key;
                    }
                    Console.WriteLine("\nEnter new description:");
                    string newDescription = Console.ReadLine();
                    if (newDescription.Length < 1)
                    {
                        newDescription = gear.Value;

                    }
                    gearList.Remove(gear.Key);
                    gearList.Add(newModel, newDescription);
                    Console.WriteLine("\nUpdated");
                    return;
                }
            }
            Console.WriteLine("Not found");

        }

        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("**********Gear List**********");
            foreach (KeyValuePair<string, string> gear in gearList)
            {
                Console.WriteLine("\n" + gear.Key + " " + gear.Value);
            }
            Console.WriteLine("\n*****************************");
        }


    }
}
