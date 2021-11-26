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
        public readonly string Info;



        public Item(ItemName name, string info)
        {
            Name = name;
            Info = info;
        }
        


        public void Stats()
        {
            Console.WriteLine("===Enemy Stats===\n" +
                              $"| Name        | {Name}\n" +
                              $"| MpCost      | 0 \n" +
                              $"| Info        | {Info}\n");
        }

        
    }
}