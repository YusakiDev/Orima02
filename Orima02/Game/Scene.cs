using System;

namespace Orima02
{
    public class Scene
    {
        public double SceneIndex { get; private set; }
        public int TextDelay;
        public string[] Text;


        public Scene(double sceneIndex, int textDelay, string[] text)
        {
            SceneIndex= sceneIndex;
            TextDelay = textDelay;
            Text = text;
        }

        public void DisplayScene()
        {
            int line = 0;
            while (line < Text.Length)
            {
                Console.WriteLine("****************");
                Console.WriteLine("*   Dialogue   *");
                Console.WriteLine("****************");
                for (int i = 0; i < Text[line].Length; i++)
                {
                    Console.Write(Text[line][i]);
                    System.Threading.Thread.Sleep(TextDelay);
                }
                Console.WriteLine("[Enter]");
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    line++;
                }
                else
                {
                    Console.Clear();
                    continue;
                }
            }
        }
        
        
        
        // var text = new string[7];
        //     text[0] = $"[1/{text.Length}] In the world of Orima, there is a farmer named {playerName}\n";
        //     text[1] = $"[2/{text.Length}] **You are the farmer {playerName}**\n";
        //     text[2] = $"[3/{text.Length}] One day he met the beautiful girl passing by so he greet her and offer her a drink.\n";
        //     text[3] = $"[4/{text.Length}] She kindly accept it and say thank you. You wish you can see her again because she is so nice.\n";
        //     text[4] = $"[5/{text.Length}] later that day, you found out that the lady was a princess that runaway from her kingdom\n";
        //     text[5] = $"[6/{text.Length}] She got kidnapped by the goblin!\n";
        //     text[6] = $"[7/{text.Length}] What should you do?\n";
        //
        //
        //
        //     while (line < text.Length)
        //     {
        //         Console.WriteLine("****************");
        //         Console.WriteLine("*   Dialogue   *");
        //         Console.WriteLine("****************");
        //         for (int i = 0; i < text[line].Length; i++)
        //         {
        //             Console.Write(text[line][i]);
        //             System.Threading.Thread.Sleep(10);
        //             if (line == 6)
        //             {
        //                 Console.WriteLine("A]Help Her\n[B]Let Her go ");
        //                 enter = Console.ReadKey();
        //                 if (enter.Key == ConsoleKey.A)
        //                 {
        //                     Console.Clear();
        //                     Console.WriteLine("You packed your items and planned for the rescue.");
        //                     break;
        //                 }
        //                 else if (enter.Key == ConsoleKey.B)
        //                 {
        //                     Console.Clear();
        //                     Ending1();
        //                 }
        //                 else
        //                 {
        //                     continue;
        //                 }
        //             }
        //         }
        //
        //         Console.WriteLine("[Enter]");
        //         enter = Console.ReadKey();
        //         if (enter.Key == ConsoleKey.Enter)
        //         {
        //             Console.Clear();
        //             line++;
        //         }
        //         else
        //         {
        //             Console.Clear();
        //             continue;
        //         }
        //     }
        
    }
}