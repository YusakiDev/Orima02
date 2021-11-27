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


        public GoblinWarrior(string name, int hp, int maxHp, int atk, int ultPoint, int maxUltPoint, bool isAlive, bool isStun, bool isPoison, int baseAtk, int stunToken, int poisonToken) : base(name, hp, maxHp, atk, ultPoint, maxUltPoint, isAlive, isStun, isPoison, baseAtk, stunToken, poisonToken)
        {
        }
    }
}