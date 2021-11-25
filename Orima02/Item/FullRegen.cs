namespace Orima02
{
    public class FullRegen: Item
    {

        public FullRegen(ItemName name, string info) : base(name, info)
        {
            
        }
        

        public static void FullHpRegen(Entity entity)
        {
            entity.AddHp(entity.MaxHp);
        }

        
    }
}