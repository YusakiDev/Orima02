using System;
using System.Threading;

namespace Orima02
{
    public class Scene
    {
        public double SceneIndex { get; }
        private readonly int _textDelay;
        private readonly string[] _text;


        public Scene(double sceneIndex, int textDelay, string[] text)
        {
            SceneIndex= sceneIndex;
            _textDelay = textDelay;
            _text = text;
        }

        public void DisplayScene()
        {
            int line = 0;
            while (line < _text.Length)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("████████████████");
                Console.WriteLine("|   Dialogue   |");
                Console.WriteLine("████████████████");
                Console.ResetColor();
                for (int i = 0; i < _text[line].Length; i++)
                {
                    Console.Write($"{_text[line][i]}");
                    Thread.Sleep(_textDelay);
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