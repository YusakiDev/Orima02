using System;

namespace Orima02
{
    public class UseableItem: Item
    {

        public UseableItem(ItemName name, string info) : base(name, info)
        {
            
        }

        public void FullRegen(Character player)
        {
            player.ModifyHp(player.MaxHp);
            Console.WriteLine("Regen to Maxhp");
        }
        
        public void DoubleDamage(Character player)
        {
            Console.WriteLine("Double Damage");
            player.ModifyAtk(player.Atk);
        }

        public void FullMp(Character player)
        {
            Console.WriteLine("Full MP");
            player.ModifyMp(player.Mp);
        }
        public void StunBomb(Enemy enemy)
        {
            Console.WriteLine("Stun Bomb");
            enemy.IsStun = true;
        }
        public void PoisonBomb(Enemy enemy)
        {
            Console.WriteLine("Poison Bomb");
            enemy.IsPoison = true;
        }
        public void DamageBomb(Enemy enemy)
        {
            Console.WriteLine("DamageBomb");
            enemy.ModifyHp(-10);
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