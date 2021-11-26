using System;
using System.Collections;
using System.Security;

namespace Orima02
{
    public class Combat
    {
        

        public void CharPassive(Character player)
        {
            player.Passive();
            player.ModifyMp(1);
            Console.WriteLine($"{player.Mp}/{player.MaxMp}");
        }

        public object ItemPhase(ArrayList inventory)
        {
            while (true)
            {
                int i = 1;
                Console.WriteLine("Welcome to Item Phase");
                Console.WriteLine("select your item");
                foreach (UseableItem item in inventory)
                {
                    Console.WriteLine($"{i}.{item.Name}");
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
                        case ConsoleKey.D0:
                        {
                            return null;
                        }
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    continue;
                }
            }
        }

        public void CheckItem(object item, ArrayList allItem, ArrayList inventory, Character player)
        {
            //TODO
            if (item == allItem[0])
            {
                UseableItem fullRegen = new UseableItem(ItemName.FullRegen, "blaBla");
                fullRegen.FullRegen(player);
                inventory.Remove(item);
            } else if (item == allItem[1])
            {
                UseableItem doubleDamage = new UseableItem(ItemName.DoubleDamage, "Bla Bla");
                doubleDamage.DoubleDamage(player);
                inventory.Remove(item);
            }else if (item == allItem[2])
            {
                
            }

        }



        public void SkillPhase(Character player)
        {
            while (true)
            {
                //TODO
                Console.WriteLine("Skill Phase");
                var userInput = Console.ReadKey(true).Key;
                
                if (userInput == ConsoleKey.D1)
                {
                    player.Skill1();
                }
                else if (userInput == ConsoleKey.D2)
                {
                    player.Skill2();
                }
                else if (userInput == ConsoleKey.D0)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    continue;
                }
            }
        }

        public void CharAutoAttack(Character player, Enemy enemy)
        {
            Console.Clear();
            Console.WriteLine("Auto Attack Phase");
            enemy.ModifyHp(-player.Atk);
        }

        public void EnemyPassive(Enemy enemy)
        {
            Console.WriteLine("Enemy Passive");
            enemy.ModifyUlt(1);
            System.Threading.Thread.Sleep(3000);
        }

        public void EnemyUltimate(Enemy enemy)
        {
            
            if (enemy.UltPoint == 3)
            {
                enemy.UltPoint = 0;
                enemy.Ultimate();
            }
            System.Threading.Thread.Sleep(3000);
        }


        public void EnemyAutoAttack(Character player, Enemy enemy)
        {
            Console.Clear();
            Console.WriteLine("Enemy Auto Attack Phase");
            player.ModifyHp(-enemy.Atk);
            Console.WriteLine($"Player has {player.Hp}Hp left\n" +
                              $"Enemy Deal {enemy.Atk}");
            System.Threading.Thread.Sleep(3000);
            
        }

        public bool CharCheckIsAlive(Character player)
        {
            return player.IsAlive;
        }

        public bool CharCheckIsStun(Character player)
        {
            return player.IsStun;
        }

        public bool CharCheckPoison(Character player)
        {
            return player.IsPoison;
        }
        
        public bool EnemyCheckIsAlive(Enemy enemy)
        {
            return enemy.IsAlive;
        }

        public bool EnemyCheckIsStun(Enemy enemy)
        {
            return enemy.IsStun;
        }

        public bool EnemyCheckPoison(Enemy enemy)
        {
            return enemy.IsPoison;
        }
        
        
        
        
        
        

        public void Debug(Character player, Enemy enemy)
        {
            Console.WriteLine($"Player HP: {player.Hp}");
            Console.WriteLine($"Enemy HP: {enemy.Hp}");
        }
    }
}