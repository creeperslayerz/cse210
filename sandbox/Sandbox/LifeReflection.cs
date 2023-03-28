public class LifeReflection : Minion
{
    //HP starts at 10 from Minion class, but can grow for each minion independently
    public override void Attack()
    {
        //ONGOING: Prevents heroes to perform any healing as long as LifeReflection is summoned
        //Size of fireMinion*5 damage to all heroes (round down to nearest 10)
    }

}