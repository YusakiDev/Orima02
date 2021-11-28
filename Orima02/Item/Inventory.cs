using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace Orima02
{
    public class Inventory
    {
        public ArrayList Items;

        public Inventory(ArrayList items)
        {
            Items = items;
        }




        //Open Inventory Method, Show Items In inventory
        public void OpenInventory()
        {
            while (true)
            {
                int i = 0;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("█████████████" + "|Inventory|" + "████████████████████");
                Console.WriteLine("| |press enter to process ....|");

                                 
                foreach (Item item in Items)
                {
                    i++;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("|\n|");
                    Console.ResetColor();
                    Console.Write($" → {i}. {item.Name}\n");
                }

                if (Console.ReadKey(true).Key == ConsoleKey.Enter)
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