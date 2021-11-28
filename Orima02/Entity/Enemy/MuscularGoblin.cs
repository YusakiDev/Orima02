using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace Orima02
{
    public class MuscularGoblin: Enemy
    {
       

        public override void Attack(Character player, Enemy enemy)
        {
            Random rnd = new Random();
            Console.WriteLine("AttackPassive: StunChance");
            if (rnd.Next(1, 6) == 1)
            {
                player.IsStun = true;
                player.ModifyStunToken(1);
                Console.WriteLine($"{player.Name} is Stunned");
                Thread.Sleep(3000);
            }
            player.ModifyHp(-Atk);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{enemy.Name} Deal {enemy.Atk} Damage to {player.Name}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{player.Name} now have {player.Hp} Hp left");
            Console.ResetColor();
            
            
        }


        public MuscularGoblin(string name, int hp, int maxHp, int atk, int ultPoint, int maxUltPoint, bool isAlive, bool isStun, bool isPoison, int baseAtk, int stunToken, int poisonToken, List<int> trapCombatIndex, List<int> trapUltimateIndex) : base(name, hp, maxHp, atk, ultPoint, maxUltPoint, isAlive, isStun, isPoison, baseAtk, stunToken, poisonToken, trapCombatIndex, trapUltimateIndex)
        {
        }

        public override void Ultimate(Character player, Enemy enemy)
        {
            Console.WriteLine($"{enemy.Name} is casting 'Road Roller'");
            Thread.Sleep(3000);
            player.ModifyHp(player.MaxHp/4);
            Console.WriteLine($"{enemy.Name} throw road roller at {player.Name}\n" +
                              $"dealing {player.MaxHp/4} damage");
        }
    }
}