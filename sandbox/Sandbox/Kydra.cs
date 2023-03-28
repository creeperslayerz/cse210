public class Kydra : Boss
{
    //Boss: Kydra
    //Pretty much the idea is to combine 3 heroes into one boss. Reminisent of a Hydra. 
    //If one head gets defeated, the remaining heads don't grow back, but have their remaining abilities strenthened.
    //That makes it interesting because the players can choose which ones to eliminate, knowing the others will be strenthened. 

    private int _greenHeadHitPoints = 150;
    private int _redHeadHitPoints = 150;
    private int _blueHeadHitPoints = 150;
    private string _lastHeadAttacked = "blue";
    private int _purpleEnergy = 1; 

    public override void BlockAttack()
    {
        base.BlockAttack();
        //If any damage is blocked, blue head is considered _lastHeadAttacked. 
    }
    public override void Attack()
    {
        //uses _primaEnergy to purchase Boost cards. Each color revealed, adds an energy of that color to Kydra. Obtains _prismaEnery as enemy spends it
    }
    public override void SpecialAttack()
    {
        //The head most recently attacked, activates it's attack
        //Green Head's attack: it has two parts, healing and attack. 10 damage healed for each _lifeEnergy to head with lowest HP; 5 damage for each _lifeEnergy to enemy with lowest HP in range (total is rounded down to nearest increment of 10) 
        //Red Head's attack: 10 damage for each _fireEnergy to enemy with hightest HP in range. 
        //Blue Head's attack: uses _purpleEnergy for Standard Attacks. Hits all enemy characters 10 for each _purpleEnergy
    }
    public void CharacterTurn()
    {
        //Add how much Prisma Energy was spent to Kydra's total _prismaEnergy
    }
    public void BossTurn()
    {
        //First, spends _prismaEnergy
        //Second, add Boost cards revealed to Kydra's energy totals
        //Third, _lastHeadAttacked activates it's attack. (If a head should attack, but has no energy, it gains 1 of that energy type instead) 
    }
}
