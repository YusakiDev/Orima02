using System;

namespace Orima02
{
    public class GameController
    {
        //menu method
        public void Menu()
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
            while (true)
            {
                Console.WriteLine("                                             Press Enter to Start...\n");
                
                Console.WriteLine("                                         x*x*x*x*x*x*x*x*x*x*x*x*x*x*x*x");
                if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    continue;
                }
            }
        }


        public string PreGame()
        {
            //pre game setting input
            Console.Clear();
            Console.Write("Please Enter Your Name:");
            string name = Console.ReadLine();
            //TODO
            return name;
        }


        public void SelectClass(Character character)
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
                character = new Magician(PreGame(),2,2,2,2, 5,true,true,true);
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
                return typeof(Swordsman);
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
               return typeof(Volunteer);
            }
            else
            {
                return null;
            }
        }
        
        
        
        
        public int ChoiceSelector(int sceneIndex)
        {
            while (true)
            {
                Console.WriteLine("===================\n" + 
                                  "|     Choice!     |\n" + 
                                  "===================");

                switch (sceneIndex)
                {
                    case 1:
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
                    case 2:
                    {
                        Console.WriteLine("scene2");
                        return 2;
                    }
                    
                }
                break;
                
            }

            return 0;
        }
        
    }
}