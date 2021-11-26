using System;

namespace Orima02
{
    public class Combat
    {
        

        public void CharPassive(Character player)
        {
            player.Passive();
            player.AddMp(1);
            Console.WriteLine($"{player.Mp}/{player.MaxMp}");
        }

        public object ItemPhase(UseableItem[] inventory)
        {
            while (true)
            {
                int i = 1;
                Console.Clear();
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
                            return inventory.GetValue(0);
                        }
                        case ConsoleKey.D2:
                        {
                            return inventory.GetValue(1);
                        }
                        case ConsoleKey.D3:
                        {
                            return inventory.GetValue(2);
                        }
                        case ConsoleKey.D4:
                        {
                            return inventory.GetValue(3);
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

        public void CheckItem(object item, UseableItem[] allitem, Character player)
        {
            //TODO
            if (item == allitem.GetValue(0))
            {
                object item1 = allitem.GetValue(0);
                
                
                UseableItem fullregen = new UseableItem(ItemName.FullRegen, "blaBla");
                fullregen.FullRegen(player);
            } else if (item == allitem.GetValue(1))
            {
                UseableItem doubledamage = new UseableItem(ItemName.DoubleDamage, "Bla Bla");
                doubledamage.DoubleDamage(player);
            }else if (item == allitem.GetValue(2))
            {
                
            }

        }



        public void SkillPhase(Character player)
        {
            while (true)
            {
                //TODO
                Console.WriteLine("Skill Phase");
                var userinput = Console.ReadKey(true).Key;
                
                if (userinput == ConsoleKey.D1)
                {
                    player.Skill1();
                }
                else if (userinput == ConsoleKey.D2)
                {
                    player.Skill2();
                }
                else if (userinput == ConsoleKey.D0)
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
            System.Threading.Thread.Sleep(3000);
            
        }

        public bool CheckIsAlive(Character player, Enemy enemy)
        {
            if (!player.IsAlive)
            {
                return false;
            }

            if (!enemy.IsAlive)
            {
                return false;
            }

            return true;
        }
        
    }
}