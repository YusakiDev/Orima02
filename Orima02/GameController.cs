using System;

namespace Orima02
{
    public class GameController
    {
        //menu method
        public void Menu()
        {
            Console.WriteLine("          ==============================================\n" +
                              "          |                                            |\n" +
                              "          |    ________        .__                     |\n" +
                              "          |    \\_____  \\_______|__| _____ _____        |\n" +
                              "          |     /   |   \\_  __ \\  |/     \\\\__  \\       |\n" +
                              "          |    /    |    \\  | \\/  |  Y Y  \\/ __ \\_     |\n" +
                              "          |    \\_______  /__|  |__|__|_|  (____  /     |\n" +
                              "          |            \\/               \\/     \\/      |\n" +
                              "          |                                            |\n" +
                              "          |          A Goblin Slayer Origin Story      |\n" +
                              "          ===============================================");
            Console.WriteLine("\n\n\n\n\n");
            while (true)
            {
                Console.WriteLine("                    Press Enter to Start...");
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


        public static string PreGame()
        {
            //pre game setting input
            Console.Write("Please Enter Your Name:");
            string name = Console.ReadLine();
            //TODO
            return name;
        }


        public void SelectClass()
        {
            ConsoleKey userInput = Console.ReadKey().Key;
            Console.WriteLine("Choose Your Class");
            Console.WriteLine("1. Magician\n" +
                              "2. Swordsman\n" +
                              "3. Volunteer");


            if (userInput == ConsoleKey.D1)
            {
                
            }
            else if(userInput == ConsoleKey.D2)
            {
                
            }
            else if (userInput == ConsoleKey.D3)
            {
                
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