public class Kydra : Boss
{
    private int _greenHeadHP = 150;
    private int _redHeadHP = 150;
    private int _blueHeadHP = 150;
    private string _lastHeadAttacked = "blue";
    private int _purpleEnergy = 1; 

    public Kydra(int hitPoints, int lifeEnergy, int fireEnergy, int aquaEnergy, int prismaEnergy) : base(hitPoints, lifeEnergy, fireEnergy, aquaEnergy, prismaEnergy)
    {
        _hitPoints = hitPoints;
        _lifeEnergy = lifeEnergy;
        _fireEnergy = fireEnergy;
        _aquaEnergy = aquaEnergy;
        _prismaEnergy = prismaEnergy;
    }

    public int GetBlueHeadHP()
    {
        return _blueHeadHP;
    }
    public void SetBlueHeadHP(int blueHeadHP) 
    {
        _blueHeadHP= blueHeadHP;
    }
    public int GetGreenHeadHP()
    {
        return _greenHeadHP;
    }
    public void SetGreenHeadHP(int greenHeadHP) 
    {
        _greenHeadHP= greenHeadHP;
    }
    public int GetRedHeadHP()
    {
        return _redHeadHP;
    }
    public void SetRedHeadHP(int redHeadHP) 
    {
        _redHeadHP= redHeadHP;
    }
    public string GetLastHeadAttacked()
    {
        return _lastHeadAttacked;
    }
    public void SetLastHeadAttacked(string lastHeadAttacked) 
    {
        _lastHeadAttacked= lastHeadAttacked;
    }
    public int GetPurpleEnergy()
    {
        return _purpleEnergy;
    }
    public void SetPurpleEnergy(int purpleEnergy) 
    {
        _purpleEnergy= purpleEnergy;
    }

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
    public override void PlayersTurn()
    {
        string playersTurn = "";
        while(playersTurn != "4")
        {
            Console.WriteLine();
            Console.WriteLine("1. Spend Prisma");
            Console.WriteLine("2. Attack");
            Console.WriteLine("3. Heal");
            Console.WriteLine("4. End Turn");
            Console.WriteLine("9. Concede Defeat");
            Console.Write("What did you do on your turn? ");
            playersTurn = Console.ReadLine();
            if(playersTurn == "1")
            {
                Console.Write("How much Prisma did you spend? ");
                string spentPrismaAsString = Console.ReadLine();
                int spentPrisma = int.Parse(spentPrismaAsString);
                int totalPrisma = _prismaEnergy + spentPrisma;
                SetPrismaEnergy(totalPrisma);
            }
            else if(playersTurn == "2")
            {
                Console.Write("How much damage did you do? ");
                string damageAsString = Console.ReadLine();
                int damage = int.Parse(damageAsString);
                int remainingHP = _hitPoints - damage;
                SetPrismaEnergy(remainingHP);
            }
            else if(playersTurn == "3")
            {
                Console.WriteLine("Wise move. Kydra will not show mercy.");
            }
            else if(playersTurn == "9")
            {
                Console.WriteLine("Better luck next time. Round up some more heroes and try again!"); //TODO: Make program end here.
            }
            else
            {
                Console.WriteLine("Please choose a valid option");
            }
        }
    }
    public void BossTurn()
    {
        //First, spends _prismaEnergy
        //Second, add Boost cards revealed to Kydra's energy totals
        //Third, _lastHeadAttacked activates it's attack. (If a head should attack, but has no energy, it gains 1 of that energy type instead) 
    }
}
