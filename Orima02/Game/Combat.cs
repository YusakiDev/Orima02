using System;

namespace Orima02
{
    public class Combat
    {
        

        public void CharPassive(Character player)
        {
            player.Passive();
            player.AddMp(1);
            Console.WriteLine($"{player.Mp}/{player.MaxMp}");
        }

        public object ItemPhase(Item[] inventory)
        {
            while (true)
            {
                int i = 1;
                Console.Clear();
                Console.WriteLine("Welcome to Item Phase");
                Console.WriteLine("select your item");
                foreach (Item item in inventory)
                {
                    Console.WriteLine($"{i}.{item.Name}");
                    i++;
                }

                try
                {
                    var userInput = Console.ReadKey(true).Key;
                    switch (userInput)
                    {
                        case ConsoleKey.D1:
                        {
                            return inventory.GetValue(0);
                        }
                        case ConsoleKey.D2:
                        {
                            return inventory.GetValue(1);
                        }
                        case ConsoleKey.D3:
                        {
                            return inventory.GetValue(2);
                        }
                        case ConsoleKey.D4:
                        {
                            return inventory.GetValue(3);
                        }
                        case ConsoleKey.D0:
                        {
                            return null;
                        }
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    continue;
                }
            }
        }

        public void CheckItem(object item, UseableItem[] allitem, Character player)
        {
            if (item == allitem.GetValue(0))
            {
                UseableItem fullregen = new UseableItem(ItemName.FullRegen, "blaBla");
                fullregen.FullRegen(player);
            } else if (item == allitem.GetValue(1))
            {
                UseableItem doubledamage = new UseableItem(ItemName.DoubleDamage, "Bla Bla");
                doubledamage.DoubleDamage(player);
            }else if (item == allitem.GetValue(2))
            {
               
            }
        }
    }
}