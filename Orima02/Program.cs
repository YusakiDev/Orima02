using System;

namespace Orima02
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            //Enemy Declaration
            GoblinGuard goblinGuard = new GoblinGuard("Goblin Guard", 1, 1, 1, 1, 1, true, false, true);
            GoblinWarrior goblinWarrior = new GoblinWarrior("Goblin Warrior", 1, 1, 1, 1, 1, true, true, true);
            
            
            
            //Character Declaration
            Magician magician = new Magician("Magician", 1, 1, 1, 1, 1, true, true, true);
            
            //Item Declaration
            FullRegen fullRegen = new FullRegen(ItemName.FullRegen, 1, $"Instantly regenerate your hp to {Entity.MaxHp}");
            
            //Inventory Declaration
            Inventory inventory = new Inventory(new Item[]{fullRegen});





            //Method

            inventory.OpenInvetory();
            
            
        }
    }
}