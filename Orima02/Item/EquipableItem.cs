namespace Orima02
{
    public class EquipableItem: Item
    {
        public int Atk;
        public int MaxMp;
        public int MaxHp;
        
        
        public EquipableItem(ItemName name,int atk, int mp, int hp, string info) : base(name, info)
        {
            Atk = atk;
            MaxMp = mp;
            MaxHp = hp;
        }
        
        
        
        
        
        
    }
}