using System;

namespace Orima02
{
    public class Volunteer: Character
    {
        

        public override void Attack()
        {
            throw new System.NotImplementedException();
        }

        public override void Skill1()
        {
            throw new System.NotImplementedException();
        }

        public override void Skill2()
        {
            throw new System.NotImplementedException();
        }

        public override void Passive()
        {
            Console.WriteLine("Volunteer Passive");
        }

        public void ShowSkill()
        {
            throw new NotImplementedException();
        }

        public Volunteer(string name, int hp, int maxHp, int mp, int maxMp, int atk, bool isAlive, bool isStun, bool isPoison, int baseAtk) : base(name, hp, maxHp, mp, maxMp, atk, isAlive, isStun, isPoison, baseAtk)
        {
        }
    }
}