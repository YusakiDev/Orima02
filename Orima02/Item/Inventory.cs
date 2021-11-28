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
                Console.WriteLine("| |Press 0 to Exit ....|");

                                 
                foreach (Item item in Items)
                {
                    i++;
                    Console.Write("|\n|");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write($" → {i}. {item.Name}\n");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("|");
                    Console.ForegroundColor = ConsoleColor.Black;
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