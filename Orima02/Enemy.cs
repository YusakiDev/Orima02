using System;
using System.Linq;

namespace Orima02
{
    public abstract class Enemy: Entity, IStats
    {
        public int UltPoint;
        public int MaxUltPoint;
        
        
        protected Enemy(string name, int hp, int maxHp, int atk, int ultpoint, int maxUltPoint, bool isAlive, bool isStun, bool isPoison) : base(name, hp, maxHp, atk, isAlive, isStun, isPoison)
        {
            UltPoint = ultpoint;
            MaxUltPoint = maxUltPoint;
        }


        public void Stats()
        {
            
            string[] stats = new string[] {CheckIfPoison(), CheckIfStunned()};
            


            Console.WriteLine("===Enemy Stats===\n" +
                              $"| Hp       | {Hp, 10}/{MaxHp}\n" +
                              $"| Atk      | {Atk, 10}\n" +
                              $"| Ultpoint | {UltPoint, 10}/{MaxUltPoint}\n" +
                              "| Stats    |          {0}", string.Join(" ", stats.Where(s => !string.IsNullOrEmpty(s))));
            
        }
        
        
        
    }
}