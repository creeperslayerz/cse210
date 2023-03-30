public abstract class Boss
{
    protected int _hitPoints;
    protected int _lifeEnergy;  
    protected int _fireEnergy;  
    protected int _aquaEnergy; 
    protected int _prismaEnergy;

    public Boss(int hitPoints, int lifeEnergy, int fireEnergy, int aquaEnergy, int prismaEnergy)
    {
        _hitPoints = hitPoints;
        _lifeEnergy = lifeEnergy;
        _fireEnergy = fireEnergy;
        _aquaEnergy = aquaEnergy;
        _prismaEnergy = prismaEnergy;
    }

    public int GetHitPoints()
    {
        return _hitPoints;
    }
    public int GetLifeEnergy()
    {
        return _lifeEnergy;
    }
    public int GetFireEnergy()
    {
        return _fireEnergy;
    }
    public int GetAquaEnergy()
    {
        return _aquaEnergy;
    }
    public int GetPrismaEnergy()
    {
        return _prismaEnergy;
    }

    public virtual void BlockAttack()
    {
        //_aquaEnergy is used to block damage. 10 damage blocked for each _aquaEnergy. 
    }
    public abstract void Attack();
    public abstract void SpecialAttack();


}