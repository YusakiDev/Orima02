using System;
using System.Linq;

namespace Orima02
{
    public enum CharClass
    {
        Magician,
        Swordsman,
        Volunteer
    }
    
    
    
    
    
    public class Character: Entity, IStats
    {
        public CharClass CharClass;
        public int Mp { get; private set; }
        public int MaxMp;

        public Character(string name,CharClass charClass, int hp, int maxHp, int mp, int maxMp, int atk, bool isAlive, bool isStun, bool isPoison, int baseAtk) : base(name, hp, maxHp, atk, isAlive, isStun, isPoison, baseAtk)
        {
            Mp = mp;
            MaxMp = maxMp;
            CharClass = charClass;
        }

        public Character()
        {
            
        }
        
        

        public void ModifyMp(int mp)
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
            string[] stats = {CheckIfPoison(), CheckIfStunned()};


            Console.WriteLine($"==={Name} Stats===\n" +
                              $"| Class    | {CharClass.ToString(),10}" +
                              $"| Hp       | {Hp, 10}/{MaxHp}\n" +
                              $"| Atk      | {Atk, 10}\n" +
                              $"| Mp       | {Mp, 10}/{MaxMp}\n" +
                              "| Stats    |          {0}", string.Join(" ", stats.Where(s => !string.IsNullOrEmpty(s))));
            Console.WriteLine();
        }


        public override void Attack()
        {
            throw new NotImplementedException();
        }
    }
}