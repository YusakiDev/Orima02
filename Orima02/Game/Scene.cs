using System;
using System.Threading;

namespace Orima02H
{
    public class Scene
    {
        public double SceneIndex { get; private set; }
        public readonly int TextDelay;
        public readonly string[] Text;


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
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("████████████████");
                Console.WriteLine("|   Dialogue   |");
                Console.WriteLine("████████████████");
                Console.ResetColor();
                for (int i = 0; i < Text[line].Length; i++)
                {
                    Console.Write($"{Text[line][i]}");
                    Thread.Sleep(TextDelay);
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
                }
            }
        }
        
        
        
        
    }
}