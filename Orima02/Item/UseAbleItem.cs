using System;
using System.Threading;

namespace Orima02
{
    public class UseAbleItem: Item
    {

        public UseAbleItem(ItemName name, string info) : base(name, info)
        {
            
        }

        public UseAbleItem()
        {
            
        }

        public void FullRegen(Character player)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{player.Name} use Item FullRegen...");
            player.ModifyHp(player.MaxHp);
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{player.Name}'s Hp is full");
            Console.ResetColor();
        }
        public void DoubleDamage(Character player)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{player.Name} use Item DoubleDamage...");
            player.ModifyAtk(player.Atk);
            Thread.Sleep(3000);
            Console.WriteLine($"{player.Name}'s Atk is Doubled");
            Console.ResetColor();
        }
        public void FullMp(Character player)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{player.Name} use Item FullMp...");
            player.ModifyMp(player.Mp);
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{player.Name}'s Mp is full");
            Console.ResetColor();
        }
        public void StunBomb(Character player,Enemy enemy)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{player.Name} use Item StunBomb...");
            enemy.ModifyHp(-2);
            enemy.IsStun = true;
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{enemy.Name} took 2 Damage and it is now stunned");
            Console.ResetColor();
        }
        public void PoisonBomb(Character player,Enemy enemy)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{player.Name} use Item PoisonBomb...");
            enemy.ModifyHp(-2);
            enemy.IsPoison = true;
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{enemy.Name} took 2 Damage and it is now poisoned");
            Console.ResetColor();
        }
        public void DamageBomb(Character player, Enemy enemy)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{player.Name} use Item Damage Bomb...");
            enemy.ModifyHp(-10);
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{enemy.Name} took 10 Damage");
            Console.ResetColor();
        }
        public void TrapDeflectDamage(Enemy enemy)
        {
            Console.WriteLine("Placing Trap DeflectDamage...");
            enemy.TrapCombatIndex.Add(1);
            Thread.Sleep(3000);
            Console.WriteLine("It Will Activate on the next Enemy AutoAttack Phase!");
        }
        public void TrapUltimateDeflect(Enemy enemy)
        {
            Console.WriteLine("Placing Trap UltimateDeflect...");
            enemy.TrapUltimateIndex.Add(1);
            Thread.Sleep(3000);
            Console.WriteLine("It Will Activate on the next Enemy Ultimate Phase!");
        }
        public void TrapWeakness(Enemy enemy)
        {
            Console.WriteLine("Placing Trap Weakness...");
            enemy.TrapUltimateIndex.Add(2);
            Thread.Sleep(3000);
            Console.WriteLine("It Will Activate on the next Enemy Ultimate Phase!");
        }
        public void AbilityTheWorld(Character player, Enemy enemy)
        {
            Random rnd = new Random();
            if (player.CheckMp(2))
            {
                Console.WriteLine("Casting Ability... 'The World!'");
                Thread.Sleep(3000);
                var i = rnd.Next(1,3);
                switch (i)
                {
                    case 1:
                        enemy.IsStun = true;
                        enemy.ModifyStunToken(1);
                        Console.WriteLine($"{enemy.Name} stunned for {i} round");
                        break;
                    case 2:
                        enemy.IsStun = true;
                        enemy.ModifyStunToken(2);
                        Console.WriteLine($"{enemy.Name} stunned for {i} round");
                        break;
                    case 3:
                        enemy.IsStun = true;
                        enemy.ModifyStunToken(3);
                        Console.WriteLine($"{enemy.Name} stunned for {i} round");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Not Enough Mana! Skipping...");
                Thread.Sleep(3000);
                
            }
        }
        public void AbilityOra(Character player, Enemy enemy)
        {
            if (player.CheckMp(4))
            {
                Console.WriteLine("Casting Ability... 'Rapid Punch'");
                Thread.Sleep(3000);
                for (int i = 0; i < player.Atk * 3; i++)
                {
                    enemy.ModifyHp(-1);
                    Console.Write("Ora! ");
                    Thread.Sleep(250);
                }
                Console.WriteLine($"\n{player.Name} Punch {enemy.Name} {player.Atk*3} times\n" +
                                  $"Dealing {player.Atk*3} Damage");
            }
            else
            {
                Console.WriteLine("Not Enough Mana! Skipping...");
                Thread.Sleep(3000);
                
            }
        }
        public void AbilityUseLeg(Character player, Enemy enemy)
        {
            if (player.CheckMp(player.MaxMp))
            {
                Console.WriteLine("Casting Ability... 'nigerundayo smokey'");
                Thread.Sleep(3000);
                Console.WriteLine("Oops!");
                Thread.Sleep(5000);
                enemy.ModifyHp(-enemy.MaxHp);
                Console.WriteLine($"{player.Name} just accidentally ran over {enemy.Name} Dealing {enemy.MaxHp} Damage");

            }
            else
            {
                Console.WriteLine("Not Enough Mana! Skipping...");
                Thread.Sleep(3000);
                
            }
        }
    }
}