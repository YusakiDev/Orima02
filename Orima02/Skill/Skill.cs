using System;
using System.Collections;
using System.Media;
using System.Threading;

namespace Orima02
{
    public enum SkillName
    {
        //Volunteer
        DamageChance,
        UseSpecialItem,
        Cheat,
        // Swordsman
        Regeneration,
        HeavyAttack,
        Dodge,
        //Magician
        MpRegen,
        FireAttack,
        Heal,
    }

    public enum SkillType
    {
        Passive, 
        Active
    }


    public class Skill : IStats
    {
        public readonly SkillName Name;
        public readonly SkillType Type;
        public readonly string Info;
        public readonly int MpCost;



        public Skill(SkillName name,SkillType type, string info, int mpCost)
        {
            Name = name;
            Type = type;
            Info = info;
            MpCost = mpCost;
        }

        public Skill()
        {
            
        }


        public void Stats()
        {
            Console.WriteLine($"==={Name} Stats===\n" +
                              $"| Name        | {Name}\n" +
                              $"| Type        | {Type}\n" +
                              $"| MpCost      | {MpCost} \n" +
                              $"| Info        | {Info}\n");
        }


        public void Cheat(Character player)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Passive: {player.Name} Just Cheated! He doubled his ATK!");
            Console.ForegroundColor = ConsoleColor.Black;
            player.ModifyAtk(player.Atk);
        }

        public void CheatChance(Character player)
        {
            player.ModifyMp(-3);
            Random rnd = new Random();

            int chance = rnd.Next(0,1);
            if (chance == 1)
            {
                //Go through
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("You cheat to double your atk again!");
                player.ModifyAtk(player.Atk);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"You now have {player.Atk} Atk");
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else
            {
                //Cheat Bomb
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Dev caught you cheating! Punishing...");
                Thread.Sleep(3000);
                player.ModifyHp(-(player.Atk*2));
                Console.WriteLine($"You Deal {player.Atk} to yourself!");
                Console.ForegroundColor = ConsoleColor.Black;
            }
        }

        public void ItemCheat(Character player,ArrayList inventory, ArrayList fullInventory, Combat combat)
        {
            player.ModifyMp(-3);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Hacking... Item Phase");
            Thread.Sleep(3000);
            Console.WriteLine("You now have second Item Phase! Tada!");
            combat.CheckItem(combat.ItemPhase(inventory), fullInventory, inventory, player );
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public void Regeneration(Character player)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Passive: You just regenerate 1 Hp");
            player.ModifyHp(1);
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public void HeavyAttack(Character player, Enemy enemy)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            player.ModifyMp(-3);
            Console.WriteLine($"{player.Name} use heavy attack...");
            Thread.Sleep(3000);
            enemy.ModifyHp(-(player.Atk + 2));
            Console.WriteLine($"{player.Name} deals {player.Atk + 2} dmg to {enemy.Name}");
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public void Fear(Character player, Enemy enemy)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            player.ModifyMp(-3);
            Console.WriteLine($"{player.Name} use Fear...");
            Thread.Sleep(3000);
            enemy.ModifyAtk(-enemy.Atk);
            Console.WriteLine($"{enemy.Name} attack decreased to 0");
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public void MpRegen(Character player)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Passive: You just regenerate 1 more Mp");
            player.ModifyMp(1); 
            Console.ForegroundColor = ConsoleColor.Black;
        }
        public void PoisonAttack(Character player, Enemy enemy)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            player.ModifyMp(-5);
            Console.WriteLine($"{player.Name} use PoisonAttack...");
            Thread.Sleep(3000);
            enemy.IsPoison = true;
            enemy.ModifyHp(-2);
            enemy.ModifyPoisonToken(3);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{player.Name} deals 2 dmg to {enemy.Name} and poisoned it");
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public void Heal(Character player)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            player.ModifyMp(-4);
            Console.WriteLine($"{player.Name} use heal...");
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{player.Name} now have {player.Hp} (+4) Hp");
            Console.ForegroundColor = ConsoleColor.Black;
        }



    }
}