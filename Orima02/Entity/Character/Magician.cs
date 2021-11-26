using System;

namespace Orima02
{
    public class Magician: Character
    {
        public Magician(string name, int hp, int maxHp, int mp, int maxMp, int atk, bool isAlive, bool isStun, bool isPoison) : base(name, hp, maxHp, mp, maxMp, atk, isAlive, isStun, isPoison)
        {
            
        }
        

        public override void Attack()
        {
            Console.WriteLine("Magician Attack!");
        }

        
        
        public override void Passive()
        {
            AddMp(1);
        }

        public void ShowSkill()
        {
            Console.WriteLine("Passive: Get 2 Mana Every Passive Phase\n" +
                              "1. Fire Attack (3 MP)\n" +
                              "   Description: Deal 3 Damage to the Enemy Instantly\n" +
                              "2. Heal (4 MP)\n" +
                              "   Description: Heal Yourself for 6 HP");
        }

        public override void Skill1()
        {
            throw new NotImplementedException();
        }

        public override void Skill2()
        {
            throw new NotImplementedException();
        }
    }
}