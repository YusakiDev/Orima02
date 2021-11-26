using System;
using System.Collections;
using System.Threading;

namespace Orima02
{
    public class GameController
    {
        //menu method
        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("                              ==============================================\n" +
                                  "                              |                                            |\n" +
                                  "                              |    ________        .__                     |\n" +
                                  "                              |    \\_____  \\_______|__| _____ _____        |\n" +
                                  "                              |     /   |   \\_  __ \\  |/     \\\\__  \\       |\n" +
                                  "                              |    /    |    \\  | \\/  |  Y Y  \\/ __ \\_     |\n" +
                                  "                              |    \\_______  /__|  |__|__|_|  (____  /     |\n" +
                                  "                              |            \\/               \\/     \\/      |\n" +
                                  "                              |                                            |\n" +
                                  "                              |          A Goblin Slayer Origin Story      |\n" +
                                  "                              ==============================================");
                Console.WriteLine("\n\n\n\n\n");

                Console.WriteLine("                                             Press Enter to Start...\n");

                Console.WriteLine("                                         x*x*x*x*x*x*x*x*x*x*x*x*x*x*x*x");
                if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.Clear();
                    continue;
                }
            }
        }

        public string GetName()
        {
            //pre game setting input
            while (true)
            {
                Console.Clear();
                Console.Write("Please Enter Your Name:");
                string name = Console.ReadLine();
                name = name.Trim();
                if (string.IsNullOrEmpty(name))
                {
                    continue;
                }

                return name;
            }
        }

        public int SelectClass()
        {
            while (true)
            {


                Console.Clear();
                Console.WriteLine("Choose Your Class");
                Console.WriteLine("1. Magician\n" +
                                  "2. Swordsman\n" +
                                  "3. Volunteer");
                ConsoleKey userInput = Console.ReadKey().Key;
                Console.Clear();

                if (userInput == ConsoleKey.D1)
                {
                    Console.WriteLine(@"
              _,._      
  .||,       /_ _\\     
 \.`',/      |'L'| |    
 = ,. =      | -,| L    
 / || \    ,-'\""/,'`.   
   ||     ,'   `,,. `.  
   ,|____,' , ,;' \| |  
  (3|\    _/|/'   _| |  
   ||/,-''  | >-'' _,\\ 
   ||'      ==\ ,-'  ,' 
   ||       |  V \ ,|   
   ||       |    |` |   
   ||       |    |   \  
   ||       |    \    \ 
   ||       |     |    \
   ||       |      \_,-'
   ||       |___,,--"")_\
   ||         |_|   ccc/
   ||        ccc/       
   ||                hjm
");
                    return 1;
                }
                else if (userInput == ConsoleKey.D2)
                {
                    Console.WriteLine(@"

 /\
 ||
 ||
 ||
 ||           {}
 ||          .--.
 ||         /.--.\
 ||         |====|
 ||         |`::`|
_||_    .-;`\..../`;_.-^-._
 /\\   /  |...::..|`   :   `|
 |:'\ |   /'''::''|   .:.   |
  \ /\;-,/\   ::  |..:::::..|
   \ <` >  >._::_.| ':::::' |
    `""""`  /   ^^  |   ':'   |
          |       \    :    /
          |        \   :   / 
          |___/\___|`-.:.-`
           \_ || _/    `
           <_ >< _>
           |  ||  |
           |  ||  |
          _\.:||:./_
    jgs  /____/\____\

");
                    return 2;
                }
                else if (userInput == ConsoleKey.D3)
                {
                    Console.WriteLine(@"

      ////^\\\\
      | ^   ^ |
     @ (o) (o) @
      |   <   |
      |  ___  |
       \_____/
     ____|  |____
    /    \__/    \
   /              \
  /\_/|        |\_/\
 / /  |        |  \ \
( <   |        |   > )
 \ \  |        |  / /
  \ \ |________| / /
   \ \|

");
                    return 3;
                }
                else
                {
                    continue;
                }

            }
        }

        public void SelectSet(Character player, EquipableItem atkSet, EquipableItem mpSet, EquipableItem hpSet,
            EquipableItem balancedSet)
        {
            Console.Clear();
            Console.WriteLine("Choose Your Beginner Enhancement\n" +
                              "1. Atk Set\n" +
                              "2. Mp Set\n" +
                              "3. Hp Set\n" +
                              "4. Balanced set");
            ConsoleKey userInput = Console.ReadKey().Key;
            if (userInput == ConsoleKey.D1)
            {
                EquipSet(player, atkSet);
            }
            else if (userInput == ConsoleKey.D2)
            {
                EquipSet(player, mpSet);
            }
            else if (userInput == ConsoleKey.D3)
            {
                EquipSet(player, hpSet);
            }
            else if (userInput == ConsoleKey.D4)
            {
                EquipSet(player, balancedSet);
            }

        }

        public void EquipSet(Character player, EquipableItem item)
        {
            player.MaxHp = player.MaxHp + item.MaxHp;
            player.ModifyAtk(item.Atk);
            player.BaseAtk = player.BaseAtk + item.Atk;
            player.MaxMp = player.MaxMp + item.MaxMp;
        }

        public int ChoiceSelector(double sceneIndex)
        {
            while (true)
            {
                Console.WriteLine("===================\n" +
                                  "|     Choice!     |\n" +
                                  "===================");

                switch (sceneIndex)
                {
                    case 1.1:
                    {
                        Console.WriteLine("1. Greet");
                        Console.WriteLine("2. Nope not me");
                        var userInput = Console.ReadKey(true).Key;

                        if (userInput == ConsoleKey.D1)
                        {
                            Console.Clear();
                            return 1;
                        }
                        else if (userInput == ConsoleKey.D2)
                        {
                            Console.Clear();
                            return 2;
                        }

                        Console.Clear();
                        continue;
                    }
                    case 1.2:
                    {
                        Console.WriteLine("1.Why did you come here?");
                        Console.WriteLine("2.pay homage to the princess?");
                        var userInput = Console.ReadKey(true).Key;
                        if (userInput == ConsoleKey.D1)
                        {
                            Console.Clear();
                            return 1;
                        }

                        if (userInput == ConsoleKey.D2)
                        {
                            Console.Clear();
                            return 2;
                        }

                        Console.Clear();
                        continue;
                    }
                    case 1.3:
                    {
                        Console.WriteLine("1.let go help");
                        Console.WriteLine("2.it's not my business ==");
                        var userInput = Console.ReadKey(true).Key;
                        if (userInput == ConsoleKey.D1)
                        {
                            Console.Clear();
                            return 1;
                        }

                        if (userInput == ConsoleKey.D2)
                        {
                            Console.Clear();
                            return 2;
                        }

                        Console.Clear();
                        continue;
                    }
                }

                break;
            }

            return 0;
        }


        public void CombatPhase(Character player, Enemy enemy, ArrayList inventory, ArrayList fullInventory,
            Combat combat)
        {
            var i = 0;
            while (true)
            {
                player.ModifyHp(player.MaxHp);
                player.ModifyMp(player.MaxMp);
                player.ResetAtk();
                while (true)
                {
                    i++;
                    Console.Clear();
                    Console.WriteLine($"Round: {i}");
                    Thread.Sleep(3000);

                    if (player.IsAlive && enemy.IsAlive)
                    {
                        //Player Passive
                        Console.Clear();
                        player.Stats();
                        combat.CharPassive(player);
                        combat.Debug(player, enemy);
                    }
                    else
                    {
                        break;
                    }

                    if (player.IsAlive && enemy.IsAlive)
                    {
                        //Player Item Phase
                        Console.Clear();
                        player.Stats();
                        combat.CheckItem(combat.ItemPhase(inventory), fullInventory, inventory, player);
                        combat.Debug(player, enemy);
                    }
                    else
                    {
                        break;
                    }

                    if (player.IsAlive && enemy.IsAlive)
                    {
                        //Player Skill Select
                        Console.Clear();
                        player.Stats();
                        combat.SkillPhase(player);
                        combat.Debug(player, enemy);
                    }
                    else
                    {
                        break;
                    }

                    if (player.IsAlive && enemy.IsAlive)
                    {
                        //Player Auto Attack
                        Console.Clear();
                        player.Stats();
                        combat.CharAutoAttack(player, enemy);
                        combat.Debug(player, enemy);
                    }
                    else
                    {
                        break;
                    }

                    if (player.IsAlive && enemy.IsAlive)
                    {
                        //Enemy Passive Phase
                        Console.Clear();
                        player.Stats();
                        combat.EnemyPassive(enemy);
                        combat.Debug(player, enemy);
                    }
                    else
                    {
                        break;
                    }

                    if (player.IsAlive && enemy.IsAlive)
                    {
                        //Enemy Ultimate Check
                        Console.Clear();
                        player.Stats();
                        combat.EnemyUltimate(enemy);
                        combat.Debug(player, enemy);
                    }
                    else
                    {
                        break;
                    }

                    if (player.IsAlive && enemy.IsAlive)
                    {
                        //Enemy Auto Attack
                        Console.Clear();
                        player.Stats();
                        combat.EnemyAutoAttack(player, enemy);
                        combat.Debug(player, enemy);
                    }
                    else
                    {
                        break;
                    }
                }
                
                if (!player.IsAlive)
                {
                    Console.Clear();
                    Console.WriteLine("You have been Defeated\n");
                    Thread.Sleep(3000);
                    Console.WriteLine("Retry?\n" +
                                      "1. Yes\n" +
                                      "2. No");
                    var userInput = Console.ReadKey(true).Key;
                    if (userInput == ConsoleKey.D1)
                    {
                        continue;
                    }
                    if (userInput == ConsoleKey.D2)
                    {
                        Environment.FailFast("Quit Program");
                    } 

                }

                if (!enemy.IsAlive)
                {
                    Console.Clear();
                    Console.WriteLine("You Defeated the Enemy\n" +
                                      "Press any button to continue...");
                    Console.ReadKey();
                    break;
                }
            }

        }

        public void RandomStage1(Inventory yourInventory, ArrayList inventory, ArrayList stage1)
        {
            var rnd = new Random();
            Console.Clear();
            Console.WriteLine("Welcome to Random Item Stage");
            Console.ReadKey();
            var random = rnd.Next(1, 3);
            switch (random)
            {
                case 1:
                {
                    Console.WriteLine("You just got new Item!");
                    inventory.Add(stage1[0]);
                    Console.ReadKey();
                    yourInventory.OpenInventory();
                    break;
                }
                case 2:
                {
                    //TODO
                    Console.WriteLine("You just got new Item!");
                    inventory.Add(stage1[1]);
                    Console.ReadKey();
                    yourInventory.OpenInventory();
                    break;
                }
                case 3:
                {
                    Console.WriteLine("You just got new Item!");
                    inventory.Add(stage1[2]);
                    Console.ReadKey();
                    yourInventory.OpenInventory();
                    break;
                }

            }

            Console.ReadKey();
        }

        public void RandomStage2(Inventory yourInventory, ArrayList inventory, ArrayList stage2)
        {
            var rnd = new Random();
            Console.Clear();
            Console.WriteLine("Welcome to Random Item Stage");
            Console.ReadKey();
            var random = rnd.Next(1, 3);
            switch (random)
            {
                case 1:
                {
                    Console.WriteLine("You just got new Item!");
                    inventory.Add(stage2[0]);
                    Console.ReadKey();
                    yourInventory.OpenInventory();
                    break;
                }
                case 2:
                {
                    Console.WriteLine("You just got new Item!");
                    inventory.Add(stage2[1]);
                    Console.ReadKey();
                    yourInventory.OpenInventory();
                    break;
                }
                case 3:
                {
                    Console.WriteLine("You just got new Item!");
                    inventory.Add(stage2[2]);
                    Console.ReadKey();
                    yourInventory.OpenInventory();
                    break;
                }

            }

            Console.ReadKey();
        }
        
        public void RandomStage3(Inventory yourInventory, ArrayList inventory, ArrayList stage3)
        {
            var rnd = new Random();
            Console.Clear();
            Console.WriteLine("Welcome to Random Item Stage");
            Console.ReadKey();
            var random = rnd.Next(1, 3);
            switch (random)
            {
                case 1:
                {
                    Console.WriteLine("You just got new Item!");
                    inventory.Add(stage3[0]);
                    Console.ReadKey();
                    yourInventory.OpenInventory();
                    break;
                }
                case 2:
                {
                    Console.WriteLine("You just got new Item!");
                    inventory.Add(stage3[1]);
                    Console.ReadKey();
                    yourInventory.OpenInventory();
                    break;
                }
                case 3:
                {
                    Console.WriteLine("You just got new Item!");
                    inventory.Add(stage3[2]);
                    Console.ReadKey();
                    yourInventory.OpenInventory();
                    break;
                }

            }
        }
        
        public void RandomStage4(Inventory yourInventory, ArrayList inventory, ArrayList stage4)
        {
            var rnd = new Random();
            Console.Clear();
            Console.WriteLine("Welcome to Random Item Stage");
            Console.ReadKey();
            var random = rnd.Next(1, 3);
            switch (random)
            {
                case 1:
                {
                    Console.WriteLine("You just got new Item!");
                    inventory.Add(stage4[0]);
                    Console.ReadKey();
                    yourInventory.OpenInventory();
                    break;
                }
                case 2:
                {
                    Console.WriteLine("You just got new Item!");
                    inventory.Add(stage4[1]);
                    Console.ReadKey();
                    yourInventory.OpenInventory();
                    break;
                }
                case 3:
                {
                    Console.WriteLine("You just got new Item!");
                    inventory.Add(stage4[2]);
                    Console.ReadKey();
                    yourInventory.OpenInventory();
                    break;
                }

            }
        }
    }
}