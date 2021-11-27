using System;
using System.Linq;

namespace Orima02
{
    public abstract class Enemy: Entity, IStats
    {
        public int UltPoint;
        public int MaxUltPoint;
        
        
        protected Enemy(string name, int hp, int maxHp, int atk, int ultPoint, int maxUltPoint, bool isAlive, bool isStun, bool isPoison, int baseAtk, int stunToken, int poisonToken) : base(name, hp, maxHp, atk, isAlive, isStun, isPoison, baseAtk, poisonToken, stunToken)
        {
            UltPoint = ultPoint;
            MaxUltPoint = maxUltPoint;
        }


        public void Stats()
        {
            
            string[] stats = {CheckIfPoison(), CheckIfStunned()};
            


            Console.WriteLine("===Enemy Stats===\n" +
                              $"| Hp       | {Hp, 10}/{MaxHp}\n" +
                              $"| Atk      | {Atk, 10}\n" +
                              $"| UltPoint | {UltPoint, 10}/{MaxUltPoint}\n" +
                              "| Stats    |          {0}", string.Join(" ", stats.Where(s => !string.IsNullOrEmpty(s))));

        }



        public abstract void Ultimate();

        public void ModifyUlt(int ultPoint)
        {
            UltPoint = UltPoint + ultPoint;

            if (UltPoint > 3)
            {
                UltPoint = 3;
            }
            else if (UltPoint < 0)
            {
                UltPoint = 0;
            }
        }
        
    }
}