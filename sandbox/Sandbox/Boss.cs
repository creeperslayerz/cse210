public abstract class Boss
{
    private int _hitPoints;
    private int _stamina;
    private int _lifeEnergy;  
    private int _fireEnergy;  
    private int _aquaEnergy; 
    private int _prismaEnergy;

    public virtual void BlockAttack()
    {
        //_aquaEnergy is used to block damage. 10 damage blocked for each _aquaEnergy. 
    }
    public abstract void Attack();
    public abstract void SpecialAttack();


}