namespace Orima02
{
    public abstract class Entity
    {
        // Entity Properties
        public string Name;
        public int Hp;
        public int MaxHp;
        public int Atk;
        public bool IsAlive;
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

        
        //force abstract use
        public abstract void Attack();
    }
}