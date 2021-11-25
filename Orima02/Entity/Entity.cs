using System;

namespace Orima02
{
    public abstract class Entity
    {
        // Entity Properties
        public string Name;
        public int Hp { get; private set; }
        public int MaxHp { get; private set; }
        public int Atk;
        public static bool IsAlive { get; private set; }
        public bool IsStun;
        public bool IsPoison;

        
        //Entity Constructors
        protected Entity(string name, int hp, int maxHp, int atk, bool isAlive, bool isStun, bool isPoison)
        {
            Name = name;
            Hp = hp;
            MaxHp = maxHp;
            Atk = atk;
            IsAlive = isAlive;
            IsStun = isStun;
            IsPoison = isPoison;
        }

        protected Entity()
        {
            
        }


        //force abstract use
        public abstract void Attack();



        public void HpSet(int hp)
        {
            if (Hp > MaxHp)
            {
                Hp = MaxHp;
            }
            else if (Hp < 0)
            {
                Hp = 0;
                IsAlive = false;
            }
        }
        
        
        
        
        
        //Check Stats
        protected string CheckIfPoison()
        {
            if (IsPoison == true)
            {
                return "Poisoned";
            }
            else
            {
                return null;
            }
        }

        protected string CheckIfStunned()
        {
            if (IsStun == true)
            {
                return "Stunned";
            }
            else
            {
                return null;
            }
        }
    }
}