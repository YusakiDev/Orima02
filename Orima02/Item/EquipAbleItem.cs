namespace Orima02
{
    public class EquipAbleItem: Item
    {
        public readonly int Atk;
        public readonly int MaxMp;
        public readonly int MaxHp;
        
        
        
        public EquipAbleItem(ItemName name,int atk, int mp, int hp, string info) : base(name, info)
        {
            Atk = atk;
            MaxMp = mp;
            MaxHp = hp;
        }
        
        
        
        
        
        
    }
}