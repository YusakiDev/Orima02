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
        
        public bool IsAlive { get; set; }
        public bool IsStun;
        public bool IsPoison;
        public int PoisonToken { get; private set; }
        public int StunToken { get; private set; }

        
        //Entity Constructors
        protected Entity(string name, int hp, int maxHp, int atk, bool isAlive, bool isStun, bool isPoison, int baseAtk, int poisonToken, int stunToken)
        {
            Name = name;
            Hp = hp;
            MaxHp = maxHp;
            Atk = atk;
            IsAlive = isAlive;
            IsStun = isStun;
            IsPoison = isPoison;
            BaseAtk = baseAtk;
            PoisonToken = poisonToken;
            StunToken = stunToken;
        }

        protected Entity()
        {
            
        }

        


        //force abstract use
        public abstract void Attack(Character player, Enemy enemy);




        public void ModifyStunToken(int token)
        {
            StunToken = StunToken + token;
            if (StunToken < 0)
            {
                StunToken = 0;
            }
        }
        public void ModifyPoisonToken(int token)
        {
            PoisonToken = PoisonToken + token;
            if (PoisonToken < 0)
            {
                PoisonToken = 0;
            }
        }
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

            if (Hp > 0)
            {
                IsAlive = true;
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

            return null;
        }

        protected string CheckIfStunned()
        {
            if (IsStun)
            {
                return "Stunned";
            }

            return null;
        }
        
    }
}