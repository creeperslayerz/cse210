public class AquaReflection : Minion
{
    public AquaReflection(int hitPoints) : base(hitPoints)
    {
        _hitPoints = hitPoints;
    }

    public override void Attack()
    {
        //Blue attack is in Anubis class as BlockAttack()... is it better here??
    }

}