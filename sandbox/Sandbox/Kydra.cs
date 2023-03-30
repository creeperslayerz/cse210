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

    public void KydraStats()
    {
        Console.WriteLine();
        Console.WriteLine("                 KYDRA");
        Console.WriteLine($"Prisma Energy = {_prismaEnergy}");
        Console.WriteLine($"Green Head HP = {_greenHeadHP}  Life Energy       = {_lifeEnergy}");
        Console.WriteLine($"Red Head HP   = {_redHeadHP}  Fire Energy       = {_fireEnergy}");
        Console.WriteLine($"Blue Head HP  = {_blueHeadHP}  Std Attack Energy = {_purpleEnergy}");
        Console.WriteLine($"Aqua Energy (Blocks attacks) = {_aquaEnergy}");
        Console.WriteLine($"Last Head Attacked = {_lastHeadAttacked}");
    }
    // public override void BlockAttack(int damage)
    // {
    //     base.BlockAttack();
    //     //If any damage is blocked, blue head is considered _lastHeadAttacked. 
    // }
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
    public override void PlayerTurn()
    {
        string playerTurn = "";
        while(playerTurn != "3")
        {
            Console.WriteLine();
            Console.WriteLine("1. Spend Prisma");
            Console.WriteLine("2. Attack");
            Console.WriteLine("3. End Turn");
            Console.WriteLine("9. Concede Defeat");
            Console.Write("What did you do on your turn? ");
            playerTurn = Console.ReadLine();
            if(playerTurn == "1")
            {
                Console.Write("How much Prisma did you spend? ");
                string spentPrismaAsString = Console.ReadLine();
                int spentPrisma = int.Parse(spentPrismaAsString);
                _prismaEnergy += spentPrisma;
                SetPrismaEnergy(_prismaEnergy);
            }
            else if(playerTurn == "2")
            {
                Console.WriteLine("Which head would you like to attack? (g/r/b) ");
                string attackedHead = Console.ReadLine();
                Console.Write("How much damage did you do? "); //TODO: add logic to determine if attack gets blocked with aquaEnergy, which also makes blue LastHeadAttacked
                string damageAsString = Console.ReadLine();
                int damage = int.Parse(damageAsString);
                
                int blockPotential = _aquaEnergy*10;
                if(blockPotential >= damage)
                {
                    Console.WriteLine($"Aqua Energy blocked {damage} damage");
                    SetAquaEnergy(_aquaEnergy - (damage/10));
                    damage -= damage;
                }
                else
                {
                    Console.WriteLine($"Aqua Energy blocked {blockPotential} damage");
                    damage -= blockPotential;
                    SetAquaEnergy(0);
                }
                
                _hitPoints -= damage;
                SetHitPoints(_hitPoints);
                if(attackedHead == "g")
                {
                    _greenHeadHP -= damage;
                    SetGreenHeadHP(_greenHeadHP);
                    SetLastHeadAttacked("green");
                }
                else if(attackedHead == "r")
                {
                    _redHeadHP -= damage;
                    SetGreenHeadHP(_redHeadHP);
                    SetLastHeadAttacked("red");
                }
                else if(attackedHead == "b")
                {
                    _greenHeadHP -= damage;
                    SetGreenHeadHP(_greenHeadHP);
                    SetLastHeadAttacked("blue");
                }
            }
            else if(playerTurn == "9")
            {
                Console.WriteLine("Better luck next time. Round up some more heroes and try again!"); 
                SetHitPoints(0);
                playerTurn = "3";
            }
        }
    }
    public override void BossTurn() //TODO: Create logic for Kydra to take its turn
    {
        //First, spends _prismaEnergy and add Boost cards revealed to Kydra's energy totals
        //Second, _lastHeadAttacked activates it's attack. (If a head should attack, but has no energy, it gains 1 of that energy type instead) 
    }
}
