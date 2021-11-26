namespace Orima02
{
    public class GoblinWarrior: Enemy
    {
        

        public override void Attack()
        {
            throw new System.NotImplementedException();
        }

        public override void Ultimate()
        {
            throw new System.NotImplementedException();
        }

        public GoblinWarrior(string name, int hp, int maxHp, int atk, int ultpoint, int maxUltPoint, bool isAlive, bool isStun, bool isPoison, int baseAtk) : base(name, hp, maxHp, atk, ultpoint, maxUltPoint, isAlive, isStun, isPoison, baseAtk)
        {
        }
    }
}