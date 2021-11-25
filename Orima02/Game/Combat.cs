using System;

namespace Orima02
{
    public class Combat
    {
        

        public void CharPassive(Character player)
        {

            player.AddMp(1);
            
            Console.WriteLine($"{player.Mp}/{player.MaxMp}");
        }
        
    }
}