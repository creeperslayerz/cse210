public class PrismaReflection : Minion
{
    public PrismaReflection(int hitPoints) : base(hitPoints)
    {
        _hitPoints = hitPoints;
    }

    public override void Attack()
    {
        //All heroes discard Prisma from their hand = size of PrismaMinion. 10 unblockable damage is dealt for each Prisma not discarded this way.
    }

}