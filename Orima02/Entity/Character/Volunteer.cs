namespace Orima02
{
    public class Volunteer: Character
    {
        public Volunteer(string name, int hp, int maxHp, int mp, int maxMp, int atk, bool isAlive, bool isStun, bool isPoison) : base(name, hp, maxHp, mp, maxMp, atk, isAlive, isStun, isPoison)
        {
        }

        public override void Attack()
        {
            throw new System.NotImplementedException();
        }
    }
}