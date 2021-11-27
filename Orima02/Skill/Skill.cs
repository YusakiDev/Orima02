using System;

namespace Orima02
{
    public enum SkillName
    {
        //Volunteer
        DamageChance,
        UseSpecialItem,
        Cheat,
        // Swordsman
        Regeneration,
        HeavyAttack,
        Dodge,
        //Magician
        MpRegen,
        FireAttack,
        Heal,
    }

    public enum SkillType
    {
        Passive, 
        Active
    }


    public class Skill : IStats
    {
        public readonly SkillName Name;
        public readonly SkillType Type;
        public readonly string Info;
        public readonly int MpCost;



        public Skill(SkillName name,SkillType type, string info, int mpCost)
        {
            Name = name;
            Type = type;
            Info = info;
            MpCost = mpCost;
        }

        public Skill()
        {
            
        }


        public void Stats()
        {
            Console.WriteLine($"==={Name} Stats===\n" +
                              $"| Name        | {Name}\n" +
                              $"| Type        | {Type}\n" +
                              $"| MpCost      | {MpCost} \n" +
                              $"| Info        | {Info}\n");
        }


        public int Cheat(int oldChance)
        {
            int newChance = oldChance + 5;
            return newChance;
        }

    }
}