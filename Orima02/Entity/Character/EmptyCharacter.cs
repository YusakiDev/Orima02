namespace Orima02
{
    public class EmptyCharacter: Orima02.Character
    {
        public EmptyCharacter() : base()
        {
            
        }

        public override void Attack()
        {
            throw new System.NotImplementedException();
        }
    }
}