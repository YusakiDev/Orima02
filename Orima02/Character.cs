namespace Orima02
{
    public abstract class Character: Entity
    {
        public int Mp;
        public int MaxMp;
            
        public Character(string name, int hp, int maxHp, int atk, bool isAlive, bool isStun, bool isPoison) : base(name, hp, maxHp, atk, isAlive, isStun, isPoison)
        {
            
        } 
        
        

        
    }
}