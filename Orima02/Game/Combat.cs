using System;
using System.Collections;
using System.Diagnostics;
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
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{player.Name} Passive Phase");
            Console.ResetColor();
            Console.WriteLine("GamePassive: You regenerated 1 Mp");
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
                    if (i == 1)
                    {
                        i++;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine($"{i}.{item.Name}");
                        Console.ResetColor();
                        item.Stats();
                        i++;
                    }
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
                catch (ArgumentOutOfRangeException)
                {
                    
                }
            }
        }

        public void CheckItem(object item, ArrayList allItem, ArrayList inventory, Character player, Enemy enemy)
        {
            if (item == allItem[0])
            {
                UseAbleItem fullRegen = new UseAbleItem();
                Console.Clear();
                player.Stats();
                enemy.Stats();
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
                UseAbleItem fullMp = new UseAbleItem();
                Console.Clear();
                player.Stats();
                fullMp.FullMp(player);
                inventory.Remove(item);
            }
            else if (item == allItem[3])
            {
                UseAbleItem stunBomb = new UseAbleItem();
                Console.Clear();
                player.Stats();
                stunBomb.StunBomb(player, enemy);
                inventory.Remove(item);
            }
            else if (item == allItem[4])
            {
                UseAbleItem poisonBomb = new UseAbleItem();
                Console.Clear();
                player.Stats();
                poisonBomb.PoisonBomb(player,enemy);
                inventory.Remove(item);
            }
            else if (item == allItem[5])
            {
                UseAbleItem damageBomb = new UseAbleItem();
                Console.Clear();
                player.Stats();
                damageBomb.DamageBomb(player,enemy);
                inventory.Remove(item);
            }else if (item == allItem[6])
            {
                UseAbleItem trapDeflect = new UseAbleItem();
                Console.Clear();
                player.Stats();
                trapDeflect.TrapDeflectDamage(enemy);
                inventory.Remove(item);
            }
            else if (item == allItem[7])
            {
                UseAbleItem trapUltimate = new UseAbleItem();
                Console.Clear();
                player.Stats();
                trapUltimate.TrapUltimateDeflect(enemy);
                inventory.Remove(item);
            }
            else if (item == allItem[8])
            {
                UseAbleItem trapWeakness = new UseAbleItem();
                Console.Clear();
                player.Stats();
                trapWeakness.TrapWeakness(enemy);
                inventory.Remove(item);
            }
            else if (item == allItem[9])
            {
                UseAbleItem abilityTheWorld = new UseAbleItem();
                Console.Clear();
                player.Stats();
                abilityTheWorld.AbilityTheWorld(player,enemy);
                inventory.Remove(item);
            }
            else if (item == allItem[10])
            {
                UseAbleItem abilityOra = new UseAbleItem();
                Console.Clear();
                player.Stats();
                abilityOra.AbilityOra(player,enemy);
                inventory.Remove(item);
            }
            else if (item == allItem[11])
            {
                UseAbleItem abilityUseLeg = new UseAbleItem();
                Console.Clear();
                player.Stats();
                abilityUseLeg.AbilityUseLeg(player,enemy);
                inventory.Remove(item);
            }


        }



        public object SkillPhase(Character player)
        {
            while (true)
            {
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
            if (skill == allSkill[0])
            {
                Skill passive = new Skill();
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
                skill2.ItemCheat(player, enemy, inventory, fullInventory, combat);
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
            if (player.IsStun)
            {
                PlayerCheckStun(player);
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine($"{player.Name} AutoAttack Phase");
                Console.ResetColor();
                player.Attack(player,enemy);
                Thread.Sleep(5000);
            }
        }

        public void EnemyPassive(Enemy enemy)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"{enemy.Name} Passive Phase");
            Console.ResetColor();
            enemy.ModifyUlt(1);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"Enemy got {enemy.UltPoint}/{enemy.MaxUltPoint} (+1) Ultpoint");
            Console.ResetColor();
            EnemyCheckPoison(enemy);
            Thread.Sleep(5000);
        }

        public void EnemyUltimate(Character player,Enemy enemy)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"{enemy.Name} Ultimate Phase");
            Console.ResetColor();
            if (enemy.UltPoint == 3)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"{enemy.Name} Casts Ultimate!");
                Console.ResetColor();
                enemy.UltPoint = 0;
                enemy.Ultimate(player, enemy);
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
                enemy.Attack(player, enemy);
                Thread.Sleep(3000);
            }
        }
        
        public void Debug(Character player, Enemy enemy)
        {
            Console.WriteLine($"Player HP: {player.Hp}");
            Console.WriteLine($"Enemy HP: {enemy.Hp}");
        }
        
        
        
        
        //Check Method


        public void PlayerCheckPoison(Character player)
        {
            if (player.PoisonToken > 0)
            {
                player.ModifyHp(-1);
                Console.WriteLine($"Poison: {player.Name} took 1 Damage from Poison");
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
                Console.WriteLine($"Poison: {enemy.Name} took 1 Damage from Poison");
                enemy.ModifyPoisonToken(-1);
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

        public bool CheckTrapUltimate(Character player, Enemy enemy)
        {
            foreach (int index in enemy.TrapCombatIndex)
            {
                if (enemy.TrapCombatIndex[index] == 1)
                {
                    Console.WriteLine("Trap Activated: Deflect Damage");
                    enemy.ModifyHp(-enemy.Atk);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{enemy.Name} Deal {enemy.Atk} Damage to itself");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{enemy.Name} now have {enemy.Hp} Hp left");
                    Console.ResetColor();
                    enemy.TrapCombatIndex.Remove(1);
                    return true;
                }

                if (enemy.TrapCombatIndex[index] == 2)
                {
                    Console.WriteLine("Trap Activated: Weakness");
                    enemy.ModifyHp(enemy.Atk / 2 - enemy.Atk);
                    Console.WriteLine($"{enemy.Name}'s Atk is now Halved");
                    Console.WriteLine($"{enemy.Name} has {enemy.Atk}");
                    Console.ResetColor();
                    enemy.TrapCombatIndex.Remove(1);
                    return false;
                }
                
            }

            return false;
        }

        public bool CheckTrapAttack(Character player, Enemy enemy)
        {
            foreach (int index in enemy.TrapUltimateIndex)
            {
                if (enemy.TrapCombatIndex[index] == 1 && enemy.UltPoint == 3)
                {
                    Console.WriteLine("Trap Activated: Deflect Ultimate");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{player.Name} deflect {enemy.Name}'s Ultimate with {(enemy.Atk + player.Atk) * 3} damage");
                    enemy.ModifyHp(-(enemy.Atk + player.Atk) * 3);
                    enemy.TrapUltimateIndex.Remove(1);
                    return true;
                }
            }

            return false;
        }




    }
}