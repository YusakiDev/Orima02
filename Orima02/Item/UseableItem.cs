using System;

namespace Orima02
{
    public class UseableItem: Item
    {

        public UseableItem(ItemName name, string info) : base(name, info)
        {
            
        }

        public void FullRegen(Character player)
        {
            player.AddHp(player.MaxHp);
            Console.WriteLine("Regen to Maxhp");
        }
        
        public void DoubleDamage(Character player)
        {
            Console.WriteLine("Double Damage");
            player.AddAtk(player.Atk);
        }
        
        
        
        
    }
}