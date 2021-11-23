namespace Orima02
{
    public class FullRegen: Item
    {

        public FullRegen(ItemName name, int mpCost, string info) : base(name, mpCost, info)
        {
            
        }
        

        public void FullHpRegen()
        {
            Entity.HpSet(Entity.MaxHp);
        }

        
    }
}