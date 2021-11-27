using System;

namespace Orima02
{
    public abstract class Entity
    {
        // Entity Properties
        public string Name { get; }
        public int Hp { get; private set; }
        public int MaxHp;
        public int Atk { get; private set; }
        public int BaseAtk;
        
        public bool IsAlive { get; private set; }
        public bool IsStun;
        public bool IsPoison;

        
        //Entity Constructors
        protected Entity(string name, int hp, int maxHp, int atk, bool isAlive, bool isStun, bool isPoison, int baseAtk)
        {
            Name = name;
            Hp = hp;
            MaxHp = maxHp;
            Atk = atk;
            IsAlive = isAlive;
            IsStun = isStun;
            IsPoison = isPoison;
            BaseAtk = baseAtk;
        }

        protected Entity()
        {
            
        }

        


        //force abstract use
        public abstract void Attack();



        public void ModifyHp(int hp)
        {
            
            Hp = Hp + hp;
            if (Hp > MaxHp)
            {
                Hp = MaxHp;
            }
            if (Hp < 0)
            {
                Hp = 0;
                IsAlive = false;
            }
        }
        
        public void ModifyAtk(int atk)
        {
            if (atk >= 0)
            {
                Atk = Atk + atk;
            }
            else
            {
                Atk = 0;
            }
        }
        
        
        
        public void ResetAtk()
        {
            Atk = BaseAtk;
        }
        
        
        
        
        
        //Check Stats
        protected string CheckIfPoison()
        {
            if (IsPoison)
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
            if (IsStun)
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