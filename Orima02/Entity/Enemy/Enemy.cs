using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Resources;

namespace Orima02
{
    public abstract class Enemy: Entity, IStats
    {
        public int UltPoint;
        public int MaxUltPoint;
        public List<int> TrapUltimateIndex;
        public List<int> TrapCombatIndex;
        
        
        protected Enemy(string name, int hp, int maxHp, int atk, int ultPoint, int maxUltPoint, bool isAlive, bool isStun, bool isPoison, int baseAtk, int stunToken, int poisonToken, List<int> trapCombatIndex, List<int> trapUltimateIndex) : base(name, hp, maxHp, atk, isAlive, isStun, isPoison, baseAtk, poisonToken, stunToken)
        {
            UltPoint = ultPoint;
            MaxUltPoint = maxUltPoint;
            TrapCombatIndex = trapCombatIndex;
            TrapUltimateIndex = trapUltimateIndex;
        }


        public void Stats()
        {
            
            string[] stats = {CheckIfPoison(), CheckIfStunned()};
            


            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"==={Name} Stats===\n" +
                              $"| Hp       | {Hp, 10}/{MaxHp}\n" +
                              $"| Atk      | {Atk, 10}\n" +
                              $"| UltPoint | {UltPoint, 10}/{MaxUltPoint}\n" +
                              "| Stats    |          {0}", string.Join(" ", stats.Where(s => !string.IsNullOrEmpty(s))));
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Black;

        }


        public abstract void Ultimate(Character player, Enemy enemy);

        public void ModifyUlt(int ultPoint)
        {
            UltPoint = UltPoint + ultPoint;

            if (UltPoint > MaxUltPoint)
            {
                UltPoint = MaxUltPoint;
            }
            else if (UltPoint < 0)
            {
                UltPoint = 0;
            }
        }
        
    }
}