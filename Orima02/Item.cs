using System;

namespace Orima02
{
    public enum ItemName
    {
        MpPotion,
        HpPotion,
        AtkPotion,
        FullRegen,
        DoubleDamage,
        FullMp,
        StunBomb,
        PoisonBomb,
        DamageBomb,
        TrapDeflect,
        TrapUltimate,
        AbilityTheWorld,
        AbilityOra,
        AbilityUseLeg,
        
    }
    
    
    public class Item: IStats
    {
        public ItemName Name;
        public string Info;
        public int MpCost;


        public Item(ItemName name, int mpCost, string info)
        {
            Name = name;
            MpCost = mpCost;
            Info = info;
        }


        public void Stats()
        {
            Console.WriteLine("===Enemy Stats===\n" +
                              $"| Name        | {Name}\n" +
                              $"| MpCost      | {MpCost, 10}\n" +
                              $"| Info        | {Info}\n");
        }
        
    }
}