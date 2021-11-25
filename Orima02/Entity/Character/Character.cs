using System;
using System.Linq;

namespace Orima02
{
    public abstract class Character: Entity, IStats
    {
        public int Mp;
        public int MaxMp;

        protected Character(string name, int hp, int maxHp, int mp, int maxMp, int atk, bool isAlive, bool isStun, bool isPoison) : base(name, hp, maxHp, atk, isAlive, isStun, isPoison)
        {
            Mp = mp;
            MaxMp = maxMp;
        }

        protected Character()
        {
            
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

        void IStats.Stats()
        {
            Stats();
        }

        public virtual void What()
        {
            Console.WriteLine("sadasdasdadadadsas");
            Console.WriteLine("sadasdasdadadadsas");
            Console.WriteLine("sadasdasdadadadsas");
            Console.WriteLine("sadasdasdadadadsas");
        }
        
        
        
        
    }
}