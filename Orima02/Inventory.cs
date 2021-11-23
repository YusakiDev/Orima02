using System;
using System.Reflection;

namespace Orima02
{
    public class Inventory
    {
        public Item[] Items;

        public Inventory(Item[] items)
        {
            Items = items;
        }




        //Open Inventory Method, Show Items In inventory
        public void OpenInventory()
        {
            while (true)
            {
                int i = 0;
                Console.WriteLine("===================\n" + "|    Inventory    |                          Press 0 to Exit ....\n" + "===================");

                foreach (Item item in Items)
                {
                    i++;
                    Console.WriteLine($"\n" + $"   {i}. {item.Name}");
                }

                if (Console.ReadKey(true).Key == ConsoleKey.D0)
                {
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    continue;
                }


                break;
            }
        }
    }
}