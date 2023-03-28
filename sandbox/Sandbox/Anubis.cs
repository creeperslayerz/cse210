public class Anubis : Boss
{
    //Boss: Anubis
    //Players actions get reflected back because Anubis is the god of judgement

    private int _fireReflectionSize = 0; 
    private int _aquaReflectionSize = 0;
    private int _lifeReflectionSize = 0;
    private int _prismaReflectionSize = 0; //is special becuase 6 energy is required to summon instead of 3 
    private int _stamina = 0;
    private int _distanceFromHeroes = 1; //Add 1 to distance when reflections are present 

    public override void BlockAttack()
    {
        base.BlockAttack();
        //flip a Boost card if _aquaReflection survives the attack. Does _aquaReflectionSize*10 attack back if Boost card = "blue" 
    }
    public void CounterAttack()
    {
        //counter attacks with "Judgement"
    }
    public override void Attack()
    {
        //attacks with "Shadow Plague" when Anubis has 20 stamina
        //if unable to attack, gain 2 stamina instead
    }
    public override void SpecialAttack()
    {
        //activates summoned Reflections at the end of each round 
    }
    public void SummonReflections()
    {
        //Summons a Reflection when Anubis has 3 of the same energy or 1 random Reflection when he has 1 of each type (4 total)
        //Each summoning adds to that energy's ReflectionSize. Going from size 0 to 1 summons it, otherwise it is already summoned and grows instead
        //If a Reflection can't be summoned or increase in size, gain 1 random energy instead
    }
}
