namespace Orima02
{
    public abstract class Entity
    {
        public string Name;
        public int Hp;
        public int Atk;
        public bool IsAlive;
        public bool IsStun;
        public bool IsPoison;

        public abstract void Attack();
    }
}