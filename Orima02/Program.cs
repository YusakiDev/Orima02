using System;

namespace Orima02
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            GoblinGuard goblinGuard = new GoblinGuard("Goblin Guard", 1, 1, 1, 1, 1, true, false, true);
            Magician magician = new Magician("Magician", 1, 1, 1, 1, 1, true, true, true);
            
            magician.Stats();
            goblinGuard.Stats();


        }
    }
}