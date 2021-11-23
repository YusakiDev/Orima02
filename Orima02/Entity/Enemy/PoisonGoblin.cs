namespace Orima02
{
    public class PoisonGoblin: Enemy
    {
        public PoisonGoblin(string name, int hp, int maxHp, int atk, int ultpoint, int maxUltPoint, bool isAlive, bool isStun, bool isPoison) : base(name, hp, maxHp, atk, ultpoint, maxUltPoint, isAlive, isStun, isPoison)
        {
        }

        public override void Attack()
        {
            throw new System.NotImplementedException();
        }
    }
}