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
                    Console.Write($"{Text[line][i]}");
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
        
        
        
        
    }
}