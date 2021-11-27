using System;
using System.Threading;

namespace Orima02
{
    public class UseAbleItem: Item
    {

        public UseAbleItem(ItemName name, string info) : base(name, info)
        {
            
        }

        public UseAbleItem()
        {
            
        }

        public void FullRegen(Character player)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{player.Name} use Item Fullregen...");
            player.ModifyHp(player.MaxHp);
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{player.Name}'s Hp is full");
            Console.ForegroundColor = ConsoleColor.Black;
        }
        
        public void DoubleDamage(Character player)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{player.Name} use Item DoubleDamage...");
            player.ModifyAtk(player.Atk);
            Thread.Sleep(3000);
            Console.WriteLine($"{player.Name}'s Atk is Doubled");
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public void FullMp(Character player)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{player.Name} use Item FullMp...");
            player.ModifyMp(player.Mp);
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{player.Name}'s Mp is full");
            Console.ForegroundColor = ConsoleColor.Black;
        }
        public void StunBomb(Character player,Enemy enemy)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{player.Name} use Item StunBomb...");
            enemy.ModifyHp(-2);
            enemy.IsStun = true;
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{enemy.Name} took 2 Damage and it is now stunned");
            Console.ForegroundColor = ConsoleColor.Black;
        }
        public void PoisonBomb(Character player,Enemy enemy)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{player.Name} use Item PoisonBomb...");
            enemy.ModifyHp(-2);
            enemy.IsPoison = true;
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{enemy.Name} took 2 Damage and it is now poisoned");
            Console.ForegroundColor = ConsoleColor.Black;
        }
        public void DamageBomb(Character player, Enemy enemy)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{player.Name} use Item Damage Bomb...");
            enemy.ModifyHp(-10);
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{enemy.Name} took 10 Damage");
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public void TrapDeflect(Enemy enemy)
        {
            Console.WriteLine("TrapDeflect");
        }
        public void UltimateSteal(Enemy enemy)
        {
            Console.WriteLine("UltimateSteal");
        }
        public void TrapWeakness(Enemy enemy)
        {
            Console.WriteLine("TrapWeakness");
        }

        public void AbilityTheWorld(Enemy enemy)
        {
            Console.WriteLine("The World!!");
        }

        public void AbilityOra(Enemy enemy)
        {
            Console.WriteLine("Ora! Ora!");
        }

        public void AbilityUseLeg(Enemy enemy)
        {
            Console.WriteLine("IMMA RUN NOW!");
        }




    }
}