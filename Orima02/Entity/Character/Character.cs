using System;
using System.Collections;
using System.Linq;

namespace Orima02
{
    public enum CharClass
    {
        Magician,
        Swordsman,
        Volunteer
    }
    
    
    public class Character: Entity, IStats
    {
        private readonly CharClass _charClass;
        public readonly ArrayList Skills;
        public int Mp { get; private set; }
        public int MaxMp;

        public Character(string name,CharClass charClass, int hp, int maxHp, int mp, int maxMp, int atk, bool isAlive, bool isStun, bool isPoison, int baseAtk,int poisonToken, int stunToken, ArrayList skills) : base(name, hp, maxHp, atk, isAlive, isStun, isPoison, baseAtk, poisonToken, stunToken)
        {
            Mp = mp;
            MaxMp = maxMp;
            _charClass = charClass;
            Skills = skills;
        }

        public Character()
        {
            
        }
        
        

        public void ModifyMp(int mp)
        {
            Mp = Mp + mp;

            if (Mp > MaxMp)
            {
                Mp = MaxMp;
            }
            else if (Hp < 0)
            {
                Mp = 0;
            }
        }

        public bool CheckMp(int mp)
        {
            if (Mp >= mp)
            {
                Mp = Mp - mp;
                return true;
            }
            
            return false;
        }
        

        public void Stats()
        {
            string[] stats = {CheckIfPoison(), CheckIfStunned()};

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"==={Name} Stats===\n" +
                              $"| Class    | {_charClass, 15}\n" +
                              $"| Hp       | {Hp, 10}/{MaxHp}\n" +
                              $"| Atk      | {Atk, 10}\n" +
                              $"| Mp       | {Mp, 10}/{MaxMp}\n" +
                              "| Stats    |        {0}", string.Join(" ", stats.Where(s => !string.IsNullOrEmpty(s))));
            Console.WriteLine();
            Console.ResetColor();
        }

        
        
        

        public override void Attack(Character player, Enemy enemy)
        {
            enemy.ModifyHp(-Atk);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{player.Name} Deal {player.Atk} Damage to {enemy.Name}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{enemy.Name} now have {enemy.Hp} Hp left");
            Console.ResetColor();
        }
    }
}