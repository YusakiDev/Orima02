using System;

namespace Orima02
{
    public class Combat
    {

        public Character Magician { get; set; }

        public void CharPassive(Character player)
        {

            if (player == Magician)
            {
                player.AddMp(1);
            }

            player.AddMp(1);
            
            Console.WriteLine($"{player.Mp}/{player.MaxMp}");
        }


    }
}