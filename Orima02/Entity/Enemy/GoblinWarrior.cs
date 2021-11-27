using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace Orima02
{
    public class GoblinWarrior: Enemy
    {
        

        public override void Attack(Character player, Enemy enemy)
        {
            Console.WriteLine("AttackPassive: None");
            player.ModifyHp(-Atk);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{enemy.Name} Deal {enemy.Atk} Damage to {player.Name}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{player.Name} now have {player.Hp} Hp left");
            Console.ResetColor();
        }


        public GoblinWarrior(string name, int hp, int maxHp, int atk, int ultPoint, int maxUltPoint, bool isAlive, bool isStun, bool isPoison, int baseAtk, int stunToken, int poisonToken, List<int> trapCombatIndex, List<int> trapUltimateIndex) : base(name, hp, maxHp, atk, ultPoint, maxUltPoint, isAlive, isStun, isPoison, baseAtk, stunToken, poisonToken, trapCombatIndex, trapUltimateIndex)
        {
        }

        public override void Ultimate(Character player, Enemy enemy)
        {
            Console.WriteLine($"{enemy.Name} is casting 'Enhance Sword'");
            Thread.Sleep(3000);
            enemy.ModifyAtk(5);
            Console.WriteLine($"{enemy.Name} gain 5 Atk Damage");
        }
    }
}