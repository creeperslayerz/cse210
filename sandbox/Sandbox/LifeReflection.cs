public class LifeReflection : Minion
{
    public LifeReflection(int hitPoints) : base(hitPoints)
    {
        _hitPoints = hitPoints;
    }
    
    public override void Attack()
    {
        //ONGOING: Prevents heroes to perform any healing as long as LifeReflection is summoned
        //Size of fireMinion*5 damage to all heroes (round down to nearest 10)
    }


}