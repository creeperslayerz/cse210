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

    public override void BossStats()
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
    public override void Attack()
    {
        //uses _primaEnergy to purchase Boost cards. Each color revealed, adds an energy of that color to Kydra. (Obtains _prismaEnery as heroes spend it)
        int boost = _prismaEnergy/2;
        while(boost >= 1)
        {
            Console.Write("Kydra spends 2 Prisma. Flip a boost card. What color is it? (g/r/b/p/wild) ");
            string gainedEnergy = Console.ReadLine();
            if(gainedEnergy == "g")
            {
                Console.WriteLine("Kydra gains 1 Life Energy");
                SetLifeEnergy(_lifeEnergy+1);
            }
            else if(gainedEnergy == "r")
            {
                Console.WriteLine("Kydra gains 1 Fire Energy");
                SetFireEnergy(_fireEnergy+1);
            }
            else if(gainedEnergy == "b")
            {
                Console.WriteLine("Kydra gains 1 Aqua Energy");
                SetAquaEnergy(_aquaEnergy+1);
            }
            else if(gainedEnergy == "p")
            {
                Console.WriteLine("Kydra gains 1 Std Attack Energy");
                SetPurpleEnergy(_purpleEnergy+1);
            }
            else if(gainedEnergy == "wild")
            {
                Console.WriteLine("Kydra gains 1 to all 4 Energy types");
                SetLifeEnergy(_lifeEnergy+1);
                SetFireEnergy(_fireEnergy+1);
                SetAquaEnergy(_aquaEnergy+1);
                SetPurpleEnergy(_purpleEnergy+1);
            }
            SetPrismaEnergy(_prismaEnergy-2);
            boost -= 1;
        }        
    }
    public override void SpecialAttack()
    {
        //The head most recently attacked, activates it's attack. If it can't attack, it gains 1 energy instead.
        if(_lastHeadAttacked == "green")
        {
            //Green Head's attack: it has two parts: 1) healing, 10 damage healed for each _lifeEnergy to head with lowest HP
            int healingPotential = _lifeEnergy*10;
            if(healingPotential >=10)
            {
                int lowestHeadHP = Math.Min(_greenHeadHP, (Math.Min(_redHeadHP, _blueHeadHP)));
                int newHealth = healingPotential + lowestHeadHP;
                if(lowestHeadHP == _blueHeadHP)
                {
                    Console.WriteLine($"Blue head gains {healingPotential} HP");
                    SetBlueHeadHP(newHealth);
                }
                else if(lowestHeadHP == _greenHeadHP)
                {
                    Console.WriteLine($"The Green head gains {healingPotential} HP");
                    SetGreenHeadHP(newHealth);
                }
                else if(lowestHeadHP == _redHeadHP)
                {
                    Console.WriteLine($"The Red head gains {healingPotential} HP");
                    SetRedHeadHP(newHealth);
                }
                // 2) Attack, 5 damage for each _lifeEnergy to enemy with lowest HP (total is rounded down to nearest increment of 10)
                int attackPotential = _lifeEnergy*5;
                Console.WriteLine($"Green head attacks the hero with the lowest HP for {attackPotential} damage (rounded down to nearest 10) ");
                string pause = Console.ReadLine();
                SetLifeEnergy(0);
            }
            else
            {
                Console.WriteLine("Kydra gains 1 Life Energy ");
                string pause = Console.ReadLine(); 
                SetLifeEnergy(_lifeEnergy+1);
            }
        }
        else if(_lastHeadAttacked == "red")
        {
            //Red Head's attack: 10 damage for each _fireEnergy to enemy with hightest HP 
            int attackPotential = _fireEnergy*10;
            if(attackPotential >= 10)
            {
                Console.WriteLine($"Red head attacks the hero with the highest HP for {attackPotential} damage ");
                string pause = Console.ReadLine();
                SetFireEnergy(0);
            }
            else
            {
                Console.WriteLine("Kydra gains 1 Fire Energy ");
                string pause = Console.ReadLine(); 
                SetFireEnergy(_fireEnergy+1);
            }
        }
        else if(_lastHeadAttacked == "blue")
        {
            //Blue Head's attack: uses _purpleEnergy for Standard Attacks. Hits all enemy characters 10 for each _purpleEnergy
            int attackPotential = _purpleEnergy*10;
            if(attackPotential >= 10)
            {
                Console.WriteLine($"Blue head attacks all heroes for {attackPotential} damage ");
                string pause = Console.ReadLine();
                SetPurpleEnergy(0);
            }
            else
            {
                Console.WriteLine("Kydra gains 1 Std Attack Energy ");
                string pause = Console.ReadLine(); 
                SetPurpleEnergy(_purpleEnergy+1);
            }
        }
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
            Console.Write("What action do you perform? ");
            playerTurn = Console.ReadLine();
            if(playerTurn == "1")
            {
                Console.Write("How much Prisma did you spend? ");
                string spentPrismaAsString = Console.ReadLine();
                int spentPrisma = int.Parse(spentPrismaAsString);
                _prismaEnergy += spentPrisma;
                SetPrismaEnergy(_prismaEnergy);
                Console.WriteLine($"Kydra gains {spentPrisma} Prisma");
            }
            else if(playerTurn == "2")
            {
                Console.WriteLine("Which head would you like to attack? (g/r/b) ");
                string attackedHead = Console.ReadLine();
                Console.Write("How much damage did you do? "); 
                string damageAsString = Console.ReadLine();
                int damage = int.Parse(damageAsString);
                
                int blockPotential = _aquaEnergy*10; //TODO: Rework logic so blue is last head attacked if it blocks any damage.
                if(blockPotential >= damage)
                {
                    Console.WriteLine($"*Aqua Energy blocked {damage} damage*");
                    SetAquaEnergy(_aquaEnergy - (damage/10)); 
                    damage -= damage;
                }
                else
                {
                    Console.WriteLine($"*Aqua Energy blocked {blockPotential} damage*");
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
                    SetRedHeadHP(_redHeadHP);
                    SetLastHeadAttacked("red");
                }
                else if(attackedHead == "b")
                {
                    _blueHeadHP -= damage;
                    SetBlueHeadHP(_blueHeadHP);
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
}
