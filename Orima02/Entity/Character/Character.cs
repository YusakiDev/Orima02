using System;
using System.Linq;

namespace Orima02
{
    public abstract class Character: Entity, IStats
    {
        public int Mp { get; private set; }
        public int MaxMp;

        protected Character(string name, int hp, int maxHp, int mp, int maxMp, int atk, bool isAlive, bool isStun, bool isPoison) : base(name, hp, maxHp, atk, isAlive, isStun, isPoison)
        {
            Mp = mp;
            MaxMp = maxMp;
        }

        protected Character()
        {
            
        }

        public abstract void Skill1();
        public abstract void Skill2();
        public abstract void Passive();
        

        public void AddMp(int mp)
        {
            Mp = Mp + mp;
            
            
            
            if (Mp > MaxMp)
            {
                Mp = MaxMp;
            }
            else if (Hp < 0)
            {
                Mp = 0;
            }
        }
        
        
        

        public void Stats()
        {
            string[] stats = new string[] {CheckIfPoison(), CheckIfStunned()};


            Console.WriteLine($"==={Name} Stats===\n" +
                              $"| Hp       | {Hp, 10}/{MaxHp}\n" +
                              $"| Atk      | {Atk, 10}\n" +
                              $"| Mp       | {Mp, 10}/{MaxMp}\n" +
                              "| Stats    |          {0}", string.Join(" ", stats.Where(s => !string.IsNullOrEmpty(s))));
        }
        
        
        
        
        
        
    }
}