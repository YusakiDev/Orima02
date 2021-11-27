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
            Console.WriteLine($"Passive: {player.Name} Just Cheated! He doubled his ATK!");
            player.ModifyAtk(player.Atk);
        }

        public void CheatChance(Character player)
        {
            if (player.CheckMp(3))
            {
                Random rnd = new Random();

                int chance = rnd.Next(0, 1);
                if (chance == 1)
                {
                    //Go through
                    Console.WriteLine("You cheat to double your atk again!");
                    player.ModifyAtk(player.Atk);
                    Console.WriteLine($"You now have {player.Atk} Atk");
                }
                else
                {
                    //Cheat Bomb
                    Console.WriteLine("Dev caught you cheating! Punishing...");
                    Thread.Sleep(3000);
                    player.ModifyHp(-(player.Atk * 2));
                    Console.WriteLine($"You Deal {player.Atk} to yourself!");
                }
                
            }
            else
            {
                Console.WriteLine("Not Enough Mana! Skipping...");
                Thread.Sleep(3000);
                
            }
        }

        public void ItemCheat(Character player,ArrayList inventory, ArrayList fullInventory, Combat combat)
        {
            if (player.CheckMp(3))
            {
                Console.WriteLine("Hacking... Item Phase");
                Thread.Sleep(3000);
                Console.WriteLine("You now have second Item Phase! Tada!");
                combat.CheckItem(combat.ItemPhase(inventory), fullInventory, inventory, player);
            }else
            {
                Console.WriteLine("Not Enough Mana! Skipping...");
                Thread.Sleep(3000);
                
            }
        }

        public void Regeneration(Character player)
        {
            Console.WriteLine("Passive: You just regenerate 1 Hp");
            player.ModifyHp(1);
        }

        public void HeavyAttack(Character player, Enemy enemy)
        {
            if (player.CheckMp(3))
            {
                Console.WriteLine($"{player.Name} use heavy attack...");
                Thread.Sleep(3000);
                enemy.ModifyHp(-(player.Atk + 2));
                Console.WriteLine($"{player.Name} deals {player.Atk + 2} dmg to {enemy.Name}");
            }else
            {
                Console.WriteLine("Not Enough Mana! Skipping...");
                Thread.Sleep(3000);
                
            }
        }

        public void Fear(Character player, Enemy enemy)
        {
            if (player.CheckMp(3))
            {
                Console.WriteLine($"{player.Name} use Fear...");
                Thread.Sleep(3000);
                enemy.ModifyAtk(-enemy.Atk);
                Console.WriteLine($"{enemy.Name} attack decreased to 0");
            }else
            {
                Console.WriteLine("Not Enough Mana! Skipping...");
                Thread.Sleep(3000);
                
            }
        }

        public void MpRegen(Character player)
        {
            Console.WriteLine("Passive: You just regenerate 1 more Mp");
            player.ModifyMp(1);
        }
        public void PoisonAttack(Character player, Enemy enemy)
        {
            if (player.CheckMp(5))
            {
                Console.WriteLine($"{player.Name} use PoisonAttack...");
                Thread.Sleep(3000);
                enemy.IsPoison = true;
                enemy.ModifyHp(-2);
                enemy.ModifyPoisonToken(3);
                Console.WriteLine($"{player.Name} deals 2 dmg to {enemy.Name} and poisoned it");
            }else
            {
                Console.WriteLine("Not Enough Mana! Skipping...");
                Thread.Sleep(3000);
                
            }
        }

        public void Heal(Character player)
        {
            if (player.CheckMp(4))
            {
                Console.WriteLine($"{player.Name} use heal...");
                Thread.Sleep(3000);
                player.ModifyHp(4);
                Console.WriteLine($"{player.Name} now have {player.Hp} (+4) Hp");
            }else
            {
                Console.WriteLine("Not Enough Mana! Skipping...");
                Thread.Sleep(3000);
            }
        }

        
    }
}