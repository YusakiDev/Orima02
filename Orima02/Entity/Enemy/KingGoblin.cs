using System;
using System.Collections.Generic;
using System.Threading;

namespace Orima02
{
    public class KingGoblin: Enemy
    {
        

        public override void Attack(Character player, Enemy enemy)
        {
            Random rnd = new Random();
            Console.WriteLine("AttackPassive: Double Attack");
            if (rnd.Next(1, 3) == 1)
            {
                player.ModifyHp(-Atk);
                Console.WriteLine($"{enemy.Name} quickly hit you with an attack that deals {enemy.Atk} Damage");
                Thread.Sleep(3000);
            }
            player.ModifyHp(-Atk);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{enemy.Name} Deal {enemy.Atk} Damage to {player.Name}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{player.Name} now have {player.Hp} Hp left");
            Console.ResetColor();
        }
        


        public KingGoblin(string name, int hp, int maxHp, int atk, int ultPoint, int maxUltPoint, bool isAlive, bool isStun, bool isPoison, int baseAtk, int stunToken, int poisonToken, List<int> trapCombatIndex, List<int> trapUltimateIndex) : base(name, hp, maxHp, atk, ultPoint, maxUltPoint, isAlive, isStun, isPoison, baseAtk, stunToken, poisonToken, trapCombatIndex, trapUltimateIndex)
        {
        }

        public override void Ultimate(Character player, Enemy enemy)
        {
            Random rnd = new Random();
            var i = rnd.Next(1, 4);
            Console.WriteLine($"{enemy.Name} is casting 'King Goblin Super Buff'");
            Thread.Sleep(3000);
            if (i == 1)
            {
                Console.WriteLine($"{enemy.Name} Mighty Attack Buff");
                enemy.ModifyAtk(enemy.Atk * 3);
                Console.WriteLine($"{enemy.Name} receive {enemy.Atk * 3} Atk");
            }
            else if (i == 2)
            {
                Console.WriteLine("King Regeneration");
                enemy.ModifyHp(enemy.MaxHp/4);
                Console.WriteLine($"{enemy.Name} receive {enemy.Atk * 3} Atk");
                
            }
            else if (i == 3)
            {
                Console.WriteLine("The Great DeBuff");
                player.ModifyHp(-player.Hp/8);
                player.ModifyMp(-player.Mp/4);
                player.IsPoison = true;
                player.ModifyPoisonToken(3);
                player.IsStun = true;
                player.ModifyStunToken(1);
                Console.WriteLine($"{player.Name} receive {-player.Hp/8} Hp, {-player.Mp/4} Mp, Stunned, Poisoned");
            }
        }
    }
}