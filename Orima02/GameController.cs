using System;
using System.Diagnostics.Contracts;
using System.Xml.Serialization.Configuration;

namespace Orima02
{
    public class GameController
    {
        
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
                            Console.WriteLine("You choose to greet her");
                            Console.Clear();
                            return 1;
                        } 
                        if (Console.ReadKey(true).Key == ConsoleKey.D2)
                        {
                            Console.WriteLine("You choose to Ditch Her");
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