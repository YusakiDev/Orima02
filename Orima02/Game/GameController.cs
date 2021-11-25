using System;

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
                else if(userInput == ConsoleKey.D2)
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

        public void SelectSet(Character player, EquipableItem atkset,EquipableItem mpset, EquipableItem hpset, EquipableItem balancedset)
        {
            Console.Clear();
            Console.WriteLine("Choose Your Beginner Enhancement\n" +
                              "1. Atk Set\n" +
                              "2. Mp Set\n" +
                              "3. Hp Set\n" +
                              "3. Balanced set");
            ConsoleKey userinput = Console.ReadKey().Key;
            if (userinput == ConsoleKey.D1)
            {
                EquipSet(player, atkset);
            }
            else if (userinput == ConsoleKey.D2)
            {
                EquipSet(player, mpset);
            }
            else if (userinput == ConsoleKey.D3)
            {
                EquipSet(player, hpset);
            }
            else if (userinput == ConsoleKey.D4)
            {
                EquipSet(player,balancedset);
            }
            
        }
        
        public void EquipSet(Character player, EquipableItem item)
        {
            player.MaxHp = player.MaxHp + item.MaxHp;
            player.AddAtk(item.Atk);
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
                    
                        if (Console.ReadKey(true).Key == ConsoleKey.D1)
                        {
                            Console.Clear();
                            return 1;
                        } 
                        if (Console.ReadKey(true).Key == ConsoleKey.D2)
                        {
                            Console.Clear();
                            return 2;
                        }
                        else
                        {
                            Console.Clear();
                            continue;
                        }
                    }
                    case 1.2:
                    {
                        Console.WriteLine("1.Why did you come here?");
                        Console.WriteLine("2.pay homage to the princess?");
                        if (Console.ReadKey(true).Key == ConsoleKey.D1)
                        {
                            Console.Clear();
                            return 1;
                        } 
                        if (Console.ReadKey(true).Key == ConsoleKey.D2)
                        {
                            Console.Clear();
                            return 2;
                        }
                        else
                        {
                            Console.Clear();
                            continue;
                        }
                    }
                    case 1.3:
                    {
                        Console.WriteLine("1.let go help");
                        Console.WriteLine("2.it's not my business ==");
                        if (Console.ReadKey(true).Key == ConsoleKey.D1)
                        {
                            Console.Clear();
                            return 1;
                        } 
                        if (Console.ReadKey(true).Key == ConsoleKey.D2)
                        {
                            Console.Clear();
                            return 2;
                        }
                        else
                        {
                            Console.Clear();
                            continue;
                        }
                    }
                        
                    
                }
                break;
                
            }

            return 0;
        }


        public void CombatPhase(Character player, Enemy enemy,Item[] inventory,UseableItem[] fullinventory, Combat combat)
        {
            Console.Clear();
            Console.WriteLine("Enter Combat Mode");

            combat.CharPassive(player);
            System.Threading.Thread.Sleep(5000);
            combat.CheckItem(combat.ItemPhase(inventory),fullinventory, player);

        }
        
        
        
        
    }
}