using System;
using System.Collections;
using System.Diagnostics.Contracts;
using System.Security;
using System.Threading;

namespace Orima02
{
    public class Combat
    {
        

        public void CharPassive(Character player,Enemy enemy, ArrayList allSkill, Combat combat, ArrayList inventory, ArrayList fullInventory)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"{player.Name} Passive Phase");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("GamePassive: You regenerated 1 Mp");
            Console.ForegroundColor = ConsoleColor.Black;
            PlayerCheckPoison(player);
            player.ModifyMp(1);
            Thread.Sleep(3000);
            CheckSkill(player.Skills[0], allSkill, player, enemy, combat, inventory, fullInventory);
            Console.WriteLine($"{player.Mp}/{player.MaxMp}");
        }
        

        public object ItemPhase(ArrayList inventory)
        {
            while (true)
            {
                int i = 1;
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Item Phase");
                Console.ResetColor();
                Console.WriteLine("(Please Select Your Item)\n" +
                                  "Or Press Enter to Pass...");
                foreach (UseAbleItem item in inventory)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine($"{i}.{item.Name}");
                    Console.ResetColor();
                    item.Stats();
                    i++;
                }

                try
                {
                    var userInput = Console.ReadKey(true).Key;
                    switch (userInput)
                    {
                        case ConsoleKey.D1:
                        {
                            return inventory[0];
                        }
                        case ConsoleKey.D2:
                        {
                            return inventory[1];
                        }
                        case ConsoleKey.D3:
                        {
                            return inventory[2];
                        }
                        case ConsoleKey.D4:
                        {
                            return inventory[3];
                        }
                        case ConsoleKey.D5:
                        {
                            return inventory[4];
                        }
                        case ConsoleKey.D6:
                        {
                            return inventory[5];
                        }
                        case ConsoleKey.D7:
                        {
                            return inventory[6];
                        }
                        case ConsoleKey.D8:
                        {
                            return inventory[7];
                        }
                        case ConsoleKey.D9:
                        {
                            return inventory[8];
                        }
                        
                        case ConsoleKey.Enter:
                        {
                            return null;
                        }
                        default:
                        {
                            continue;
                        }
                            
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    
                }
            }
        }

        public void CheckItem(object item, ArrayList allItem, ArrayList inventory, Character player)
        {
            //TODO
            if (item == allItem[0])
            {
                UseAbleItem fullRegen = new UseAbleItem();
                Console.Clear();
                player.Stats();
                fullRegen.FullRegen(player);
                Thread.Sleep(3000);
                inventory.Remove(item);
            } else if (item == allItem[1])
            {
                UseAbleItem doubleDamage = new UseAbleItem();
                Console.Clear();
                player.Stats();
                doubleDamage.DoubleDamage(player);
                inventory.Remove(item);
            }
            else if (item == allItem[2])
            {
                UseAbleItem doubleDamage = new UseAbleItem();
                Console.Clear();
                player.Stats();
                doubleDamage.DoubleDamage(player);
                inventory.Remove(item);
            }
            else if (item == allItem[3])
            {
                UseAbleItem doubleDamage = new UseAbleItem();
                Console.Clear();
                player.Stats();
                doubleDamage.DoubleDamage(player);
                inventory.Remove(item);
            }
            else if (item == allItem[4])
            {
                UseAbleItem doubleDamage = new UseAbleItem();
                Console.Clear();
                player.Stats();
                doubleDamage.DoubleDamage(player);
                inventory.Remove(item);
            }
            else if (item == allItem[5])
            {
                UseAbleItem doubleDamage = new UseAbleItem();
                Console.Clear();
                player.Stats();
                doubleDamage.DoubleDamage(player);
                inventory.Remove(item);
            }else if (item == allItem[6])
            {
                UseAbleItem doubleDamage = new UseAbleItem();
                Console.Clear();
                player.Stats();
                doubleDamage.DoubleDamage(player);
                inventory.Remove(item);
            }else if (item == allItem[2])
            {
                
            }

        }



        public object SkillPhase(Character player)
        {
            while (true)
            {
                //TODO
                int i = 0;
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Skill Phase");
                Console.ResetColor();
                Console.WriteLine("(Please Select Your Skill)\n" +
                                  "Or Press Enter to Pass...");
                foreach (Skill skill in player.Skills)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine($"{i}.{skill.Name}");
                    Console.ResetColor();
                    skill.Stats();
                    i++;
                }
                

                var userInput = Console.ReadKey(true).Key;
                
                if (userInput == ConsoleKey.D1)
                {
                    return player.Skills[1];
                }

                if (userInput == ConsoleKey.D2)
                {
                    return player.Skills[2];
                }

                if (userInput == ConsoleKey.Enter)
                {
                    return null;
                }
                Console.Clear();
            }
        }
        
        public void CheckSkill(object skill, ArrayList allSkill, Character player,Enemy enemy, Combat combat, ArrayList inventory, ArrayList fullInventory)
        {
            //TODO
            if (skill == allSkill[0])
            {
                Skill passive = new Skill();
                passive.Cheat(player);
                Console.Clear();
                player.Stats();
                passive.Cheat(player);
                Thread.Sleep(3000);
            } else if (skill == allSkill[1])
            {
                Skill skill1 = new Skill();
                Console.Clear();
                player.Stats();
                skill1.CheatChance(player);
                Thread.Sleep(3000);
            }else if (skill == allSkill[2])
            {
                Skill skill2 = new Skill();
                Console.Clear();
                player.Stats();
                skill2.ItemCheat(player, inventory, fullInventory, combat);
                Thread.Sleep(3000);
            }else if (skill == allSkill[3])
            {
                Skill passive = new Skill();
                Console.Clear();
                player.Stats();
                passive.Regeneration(player);
                Thread.Sleep(3000);
            }
            else if (skill == allSkill[4])
            {
                Skill skill1 = new Skill();
                Console.Clear();
                player.Stats();
                skill1.HeavyAttack(player,enemy);
                Thread.Sleep(3000);
            }
            else if (skill == allSkill[5])
            {
                Skill skill2 = new Skill();
                Console.Clear();
                player.Stats();
                skill2.Fear(player,enemy);
                Thread.Sleep(3000);
            }
            else if (skill == allSkill[6])
            {
                Skill passive = new Skill();
                Console.Clear();
                player.Stats();
                passive.MpRegen(player);
                Thread.Sleep(3000);
            }
            else if (skill == allSkill[7])
            {
                Skill skill1 = new Skill();
                Console.Clear();
                player.Stats();
                skill1.PoisonAttack(player,enemy);
                Thread.Sleep(3000);
            }
            else if (skill == allSkill[8])
            {
                Skill skill2 = new Skill();
                Console.Clear();
                player.Stats();
                skill2.Heal(player);
                Thread.Sleep(3000);
            }

        }
        
        

        public void CharAutoAttack(Character player, Enemy enemy)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"{player.Name} AutoAttack Phase");
            Console.ResetColor();
            enemy.ModifyHp(-player.Atk);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{player.Name} Deal {player.Atk} Damage to {enemy.Name}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{enemy.Name} now have {enemy.Hp} Hp left");
            Console.ForegroundColor = ConsoleColor.Black;
            Thread.Sleep(5000);
        }

        public void EnemyPassive(Enemy enemy)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"{enemy.Name} Passive Phase");
            Console.ResetColor();
            enemy.ModifyUlt(1);
            Console.WriteLine($"Enemy got {enemy.UltPoint}/{enemy.MaxUltPoint} (+1) UltPoint");
            EnemyCheckPoison(enemy);
            Thread.Sleep(5000);
        }

        public void EnemyUltimate(Enemy enemy)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"{enemy.Name} Ultimate Phase");
            Console.ResetColor();
            if (enemy.UltPoint == 3)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"{enemy.Name} Casts Ultimate!");
                Console.ForegroundColor = ConsoleColor.Black;
                enemy.UltPoint = 0;
                enemy.Ultimate();
            }
            else
            {
                Console.WriteLine("Not Enough UltPoint\n" +
                                  "Passing...");
            }
            Thread.Sleep(3000);
        }


        public void EnemyAutoAttack(Character player, Enemy enemy)
        {
            if (enemy.IsStun)
            {
                EnemyCheckStun(enemy);
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine($"{enemy.Name} AutoAttack Phase");
                Console.ResetColor();
                player.ModifyHp(-enemy.Atk);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"{enemy.Name} Deal {enemy.Atk} Damage to {player.Name}");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{player.Name} now have {player.Hp} Hp left");
                Console.ForegroundColor = ConsoleColor.Black;
                Thread.Sleep(3000);
            }
        }
        
        public void Debug(Character player, Enemy enemy)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Player HP: {player.Hp}");
            Console.WriteLine($"Enemy HP: {enemy.Hp}");
            Console.ForegroundColor = ConsoleColor.Black;
        }
        
        
        
        
        
        
        //Check Method


        public void PlayerCheckPoison(Character player)
        {
            if (player.PoisonToken > 0)
            {
                player.ModifyHp(-1);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Poison: {player.Name} took 1 Damage from Poison");
                Console.ForegroundColor = ConsoleColor.Black;
                player.ModifyPoisonToken(-1);
            }
            if (player.PoisonToken == 0)
            {
                player.IsPoison = false;
            }
        }
        public void EnemyCheckPoison(Enemy enemy)
        {
            if (enemy.PoisonToken > 0)
            {
                enemy.ModifyHp(-1);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Poison: {enemy.Name} took 1 Damage from Poison");
                enemy.ModifyPoisonToken(-1);
                Console.ForegroundColor = ConsoleColor.Black;
            }
            if (enemy.PoisonToken == 0)
            {
                enemy.IsPoison = false;
            }
        }
        
        public void PlayerCheckStun(Character player)
        {
            if (player.StunToken > 0)
            {
                Console.WriteLine($"{player.Name} is Stunned! Skipping Phase....");
                player.ModifyStunToken(-1);
            }

            if (player.StunToken == 0)
            {
                player.IsStun = false;
            }
        }
        
        public void EnemyCheckStun(Enemy enemy)
        {
            if (enemy.StunToken > 0)
            {
                Console.WriteLine($"{enemy.Name} is Stunned! Skipping Phase....");
                enemy.ModifyStunToken(-1);
            }
            if (enemy.StunToken == 0)
            {
                enemy.IsStun = false;
            }
        }
        
    }
}