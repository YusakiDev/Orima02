namespace Orima02
{
    public abstract class Character: Entity
    {
        public int Mp;
        public int MaxMp;

        protected Character(string name, int hp, int maxHp, int mp, int maxMp, int atk, bool isAlive, bool isStun, bool isPoison) : base(name, hp, maxHp, atk, isAlive, isStun, isPoison)
        {
            Mp = mp;
            MaxMp = maxMp;
        }

        
    }
}