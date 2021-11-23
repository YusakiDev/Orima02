namespace Orima02
{
    public abstract class Enemy: Entity
    {
        public int UltPoint;
        public int MaxUltPoint;
        
        
        protected Enemy(string name, int hp, int maxHp, int atk, int ultpoint, int maxUltPoint, bool isAlive, bool isStun, bool isPoison) : base(name, hp, maxHp, atk, isAlive, isStun, isPoison)
        {
            UltPoint = ultpoint;
            MaxUltPoint = maxUltPoint;
        }

        
    }
}