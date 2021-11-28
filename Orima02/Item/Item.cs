using System;

namespace Orima02
{
    public enum ItemName
    {
        MpSet,
        HpSet,
        AtkSet,
        BalanceSet,
        FullRegen,
        DoubleDamage,
        FullMp,
        StunBomb,
        PoisonBomb,
        DamageBomb,
        TrapDeflect,
        TrapUltimate,
        TrapWeakness,
        AbilityTheWorld,
        AbilityOra,
        AbilityUseLeg,
        
    }
    
    
    public class Item: IStats
    {
        public readonly ItemName Name;
        private readonly string _info;


        protected Item(ItemName name, string info)
        {
            Name = name;
            _info = info;
        }

        protected Item()
        {
            
        }
        


        public void Stats()
        {
            Console.WriteLine($"==={Name} Stats===\n" +
                              $"| Name        | {Name}\n" +
                              "| MpCost      |  ?\n" +
                              $"| Info        | {_info}\n");
        }

        
    }
}