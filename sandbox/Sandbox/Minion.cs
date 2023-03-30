public abstract class Minion
{
    protected int _hitPoints;

    public abstract void Attack();

    public Minion(int hitPoints)
    {
        _hitPoints = hitPoints;
    }
}