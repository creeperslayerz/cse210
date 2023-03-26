public class PrismaReflection : Minion
{
    //HP starts at 10 from Minion class, but can grow for each minion independently
    public override void Attack()
    {
        //All heroes discard Prisma from their hand = size of PrismaMinion. 10 unblockable damage is dealt for each Prisma not discarded this way.
    }

}