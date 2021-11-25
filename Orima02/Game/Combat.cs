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

        public void ItemPhase(Item[] inventory, Item[] fullinventory)
        {
            Console.Clear();
            Console.WriteLine("Welcome to Item Phase");
            Console.WriteLine("select your item");
            foreach (Item item in inventory)
            {
                int i = 1;
                Console.WriteLine($"{i}.{item.Name}");
                i++;
            }
            //TODO
            
            
            
            
            
        }
        
        
        
    }
}