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
    public void SetHitPoints(int hitPoints) 
    {
        _hitPoints = hitPoints;
    }
    public int GetLifeEnergy()
    {
        return _lifeEnergy;
    }
    public void SetLifeEnergy(int lifeEnergy) 
    {
        _lifeEnergy= lifeEnergy;
    }
    public int GetFireEnergy()
    {
        return _fireEnergy;
    }
    public void SetFireEnergy(int fireEnergy) 
    {
        _fireEnergy= fireEnergy;
    }
    public int GetAquaEnergy()
    {
        return _aquaEnergy;
    }
    public void SetAquaEnergy(int aquaEnergy) 
    {
        _aquaEnergy= aquaEnergy;
    }
    public int GetPrismaEnergy()
    {
        return _prismaEnergy;
    }
    public void SetPrismaEnergy(int prismaEnergy) 
    {
        _prismaEnergy= prismaEnergy;
    }

    public virtual void BlockAttack()
    {
        //_aquaEnergy is used to block damage. 10 damage blocked for each _aquaEnergy. 
    }
    public abstract void Attack();
    public abstract void SpecialAttack();
    public abstract void PlayersTurn();

}