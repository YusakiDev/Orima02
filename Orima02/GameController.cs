using System;
using System.Diagnostics.Contracts;
using System.Xml.Serialization.Configuration;

namespace Orima02
{
    public class GameController
    {
        
        public void ChoiceSelector(int sceneIndex)
        {
            while (true)
            {
                Console.WriteLine("===================\n" + 
                                  "|     Choice!     |                          Press 0 to Exit ....\n" + 
                                  "===================");

                switch (sceneIndex)
                {
                    case 1:
                    {
                    Console.WriteLine($"1. Greet");
                    
                    
                        if (Console.ReadKey(true).Key == ConsoleKey.D1)
                        {
                            Console.WriteLine("You choose to greet her");
                            break;
                        }
                        else
                        {
                            continue;
                        }    
                    }
                    case 2:
                    {
                        Console.WriteLine("scene2");
                        break;
                    }
                    
                }

                
                if (Console.ReadKey(true).Key == ConsoleKey.D0)
                {
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    continue;
                }

                break;
            }
        }
    }
}