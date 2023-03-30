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

    public Anubis(int hitPoints, int lifeEnergy, int fireEnergy, int aquaEnergy, int prismaEnergy) : base(hitPoints, lifeEnergy, fireEnergy, aquaEnergy, prismaEnergy)
    {
        _hitPoints = hitPoints;
        _lifeEnergy = lifeEnergy;
        _fireEnergy = fireEnergy;
        _aquaEnergy = aquaEnergy;
        _prismaEnergy = prismaEnergy;
    }

    public int GetFireReflectionSize()
    {
        return _fireReflectionSize;
    }
    public void SetFireReflectionSize(int fireReflectionSize) 
    {
        _fireReflectionSize = fireReflectionSize;
    }
    public int GetAquaReflectionSize()
    {
        return _aquaReflectionSize;
    }
    public void SetAquaReflectionSize(int aquaReflectionSize) 
    {
        _aquaReflectionSize = aquaReflectionSize;
    }
    public int GetLifeReflectionSize()
    {
        return _lifeReflectionSize;
    }
    public void SetLifeReflectionSize(int lifeReflectionSize) 
    {
        _lifeReflectionSize= lifeReflectionSize;
    }
    public int GetPrismaReflectionSize()
    {
        return _prismaReflectionSize;
    }
    public void SetPrismaReflectionSize(int prismaReflectionSize) 
    {
        _prismaReflectionSize = prismaReflectionSize;
    }
    public int GetStamina()
    {
        return _stamina;
    }
    public void SetStamina(int stamina) 
    {
        _stamina = stamina;
    }
    public int GetDistanceFromHeroes()
    {
        return _distanceFromHeroes;
    }
    public void SetDistanceFromHeroes(int distanceFromHeroes) 
    {
        _distanceFromHeroes = distanceFromHeroes;
    }

    public override void BossStats()
    {
        Console.WriteLine();
        Console.WriteLine("                 ANUBIS");
        Console.WriteLine($"Prisma Energy = {_prismaEnergy}/6  Reflection Size = {_prismaReflectionSize}");
        Console.WriteLine($"Life Energy   = {_lifeEnergy}/6  Reflection Size = {_lifeReflectionSize}");
        Console.WriteLine($"Fire Energy   = {_fireEnergy}/6  Reflection Size = {_fireReflectionSize}");
        Console.WriteLine($"Aqua Energy   = {_aquaEnergy}/6  Reflection Size = {_aquaReflectionSize}");
        Console.WriteLine($"Stamina = {_stamina}/20)");
        Console.WriteLine($"Hit Points = {_hitPoints}");
    }

    public override void Attack()
    {
        //attacks with "Shadow Plague" when Anubis has 20 stamina. If unable to attack, gain 2 stamina instead
        if(_stamina >= 20)
        {
            Console.WriteLine("Anubis attacks by flipping 3 Boost cards.");
            int boost = 3;
            while(boost >= 1)
            {
                Console.Write("Flip a boost card. What color is it? (g/r/b/p/wild) ");
                string boostColor = Console.ReadLine();
                if(boostColor == "r")
                {
                    Console.WriteLine("Anubis deals 10 damage to all heroes");
                }
                else if(boostColor == "b")
                {
                    Console.WriteLine("Anubis deals 10 damage to all heroes");
                }
                else if(boostColor == "g")
                {
                    Console.WriteLine("Anubis heals himself 10 hit points");
                    SetHitPoints(_hitPoints+10);
                }
                else if(boostColor == "p")
                {
                    Console.WriteLine("Anubis heals himself 10 hit points");
                    SetHitPoints(_hitPoints+10);
                }
                else if(boostColor == "wild")
                {
                    Console.WriteLine("Anubis does both 10 damage to all heroes and heals himself 10");
                    SetHitPoints(_hitPoints+10);
                }
                boost -= 1;
                _stamina -= 20;
                if(_hitPoints > 140)
                {
                    _hitPoints = 140;
                }
            }    
        }
        else
        {
            Console.Write("Anubis gains 2 Stamina, ");
            _stamina += 2;
        }
    }
    public override void SpecialAttack()
    {
        //Cast Reflection(s) when Anubis has 6 of the same energy. If a Reflection can't be cast, gain 1 energy instead 
        if(_prismaEnergy >= 6)
        {
            while(_prismaEnergy >= 6)
            {
                Console.Write("Prisma Reflection appears/grows, ");
                _prismaReflectionSize += 1;
                _prismaEnergy -= 6;
            }
        }
        else
        {
            Console.Write("+1 Prisma Energy, ");
            _prismaEnergy += 1;
        }
        if(_lifeEnergy >= 6)
        {
            while(_lifeEnergy >= 6)
            {
                Console.Write("Life Reflection appears/grows, ");
                _lifeReflectionSize += 1;
                _lifeEnergy -= 6;
            }
        }
        else
        {
            Console.Write("+1 Life Energy, ");
            _lifeEnergy += 1;
        }
        if(_fireEnergy >= 6)
        {
            while(_fireEnergy >= 6)
            {
                Console.Write("Fire Reflection appears/grows, ");
                _fireReflectionSize += 1;
                _fireEnergy -= 6;
            }
        }
        else
        {
            Console.Write("+1 Fire Energy, ");
            _fireEnergy += 1;
        }
        if(_aquaEnergy >= 6)
        {
            while(_aquaEnergy >= 6)
            {
                Console.Write("Aqua Reflection appears/grows.");
                _aquaReflectionSize += 1;
                _aquaEnergy -= 6;
            }
        }
        else
        {
            Console.Write("+1 Aqua Energy.");
            _aquaEnergy += 1;
        }
        string pause = Console.ReadLine();
    }
    public void ReflectionsAttack()
    {
        //reflections attack at the end of each round

    }
    public override void PlayerTurn()
    {
        string playerTurn = "";
        while(playerTurn != "4")
        {
            BossStats();
            Console.WriteLine();
            Console.WriteLine("1. Spend Prisma");
            Console.WriteLine("2. Attack");
            Console.WriteLine("3. Heal");
            Console.WriteLine("4. End Turn");
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
                Console.WriteLine($"Anubis gains {spentPrisma} Prisma Energy");
            }
            else if(playerTurn == "2")
            {
                Console.WriteLine("Who would you like to attack? (1.Boss, or Reflection-2.Prisma,3.Life,4.Fire,5.Aqua) ");
                string attackChoice = Console.ReadLine();
                Console.Write("How much stamina do you spend? ");
                string staminaAsString = Console.ReadLine();
                int stamina = int.Parse(staminaAsString);
                Console.WriteLine($"Anubis gains {stamina} stamina");
                _stamina += stamina;
                string spentEnergy = "";
                while(spentEnergy != "5")
                {
                    Console.WriteLine("What type(s) of Energy did you spend? ");
                    Console.WriteLine("1.Prisma, 2.Life, 3.Fire, 4.Aqua, 5.Std Attack/Done");
                    spentEnergy = Console.ReadLine();
                    if(spentEnergy == "1")
                    {
                        Console.Write("How much Prisma? ");
                        string energyAsString = Console.ReadLine();
                        int energy = int.Parse(energyAsString);
                        Console.WriteLine($"Anubis gains {energy} Prisma Energy");
                        SetPrismaEnergy(_prismaEnergy+energy);
                    }
                    if(spentEnergy == "2")
                    {
                        Console.Write("How much Life Energy? ");
                        string energyAsString = Console.ReadLine();
                        int energy = int.Parse(energyAsString);
                        Console.WriteLine($"Anubis gains {energy} Life Energy");
                        SetLifeEnergy(_lifeEnergy+energy);
                    }
                    if(spentEnergy == "3")
                    {
                        Console.Write("How much Fire Energy? ");
                        string energyAsString = Console.ReadLine();
                        int energy = int.Parse(energyAsString);
                        Console.WriteLine($"Anubis gains {energy} Fire Energy");
                        SetFireEnergy(_fireEnergy+energy);
                    }
                    if(spentEnergy == "4")
                    {
                        Console.Write("How much Aqua Energy? ");
                        string energyAsString = Console.ReadLine();
                        int energy = int.Parse(energyAsString);
                        Console.WriteLine($"Anubis gains {energy} Aqua Energy");
                        SetAquaEnergy(_aquaEnergy+energy);
                    }
                }    
                Console.Write("How much damage did you do? "); 
                string damageAsString = Console.ReadLine();
                int damage = int.Parse(damageAsString);
                
                //Blocks 10 damage per Aqua Reflection Size then counter attacks with Blue Boost card
                int blockPotential = _aquaReflectionSize*10; 
                if(blockPotential >= damage)
                {
                    Console.WriteLine($"*Aqua Reflection blocked {damage} damage*");
                    damage -= damage;
                    Console.WriteLine($"Flip a Boost card if damage was blocked."); 
                    Console.WriteLine($"If blue, Aqua Reflection counter attacks with {blockPotential} damage "); 
                    string pause = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"*Aqua Reflection blocked {blockPotential} damage*");
                    damage -= blockPotential;
                    Console.WriteLine($"Flip a Boost card if damage was blocked."); 
                    Console.WriteLine($"If blue, Aqua Reflection counter attacks with {blockPotential} damage.");
                }
                
                //Attack Choices are below
                if(attackChoice == "1")
                {
                    //Determine Anubis' distance from heroes based on if a reflection is present or not
                    if(_prismaReflectionSize>0 || _lifeReflectionSize>0 || _fireReflectionSize>0 || _aquaReflectionSize>0)
                    {
                        _distanceFromHeroes = 2;
                    }
                    else
                    {
                        _distanceFromHeroes = 1;
                    }
                    Console.WriteLine($"Anubis is range {_distanceFromHeroes} away due to presence/absence of Reflections.");
                    Console.Write("Is he in range? (y/n) ");
                    string inRange = Console.ReadLine();
                    if(inRange == "y")
                    {
                        _hitPoints -= damage;
                        SetHitPoints(_hitPoints);
                        Console.WriteLine($"You reduced Anubis' health by {damage} hit points.");
                        Console.WriteLine("If you reduced Anubis' health, flip a Boost card.");
                        Console.WriteLine("If it is not purple, place a previously discarded Clinker in the attacker's discard pile. ");
                        string pause = Console.ReadLine(); 
                    }
                    else
                    {
                        Console.WriteLine("You will need to use the attack on a Reflection instead");
                        string pause = Console.ReadLine();
                    }
                }
                else if(attackChoice == "2")
                {
                    _prismaReflectionSize = (_prismaReflectionSize*10) - damage;
                    if(_prismaReflectionSize < 0)
                    {
                        _prismaReflectionSize = 0;
                    }
                    else
                    {
                        _prismaReflectionSize /= 10;
                    }
                }
                else if(attackChoice == "3")
                {
                    _lifeReflectionSize = (_lifeReflectionSize*10) - damage;
                    if(_lifeReflectionSize < 0)
                    {
                        _lifeReflectionSize = 0;
                    }
                    else
                    {
                        _lifeReflectionSize /= 10;
                    }
                }
                else if(attackChoice == "4")
                {
                    _fireReflectionSize = (_fireReflectionSize*10) - damage;
                    if(_fireReflectionSize < 0)
                    {
                        _fireReflectionSize = 0;
                    }
                    else
                    {
                        _fireReflectionSize /= 10;
                    }
                }
                else if(attackChoice == "5")
                {
                    _aquaReflectionSize = (_aquaReflectionSize*10) - damage;
                    if(_aquaReflectionSize < 0)
                    {
                        _aquaReflectionSize = 0;
                    }
                    else
                    {
                        _aquaReflectionSize /= 10;
                    }
                }
            }
            else if(playerTurn == "3")
            {
                if(_lifeReflectionSize >= 1)
                {
                    Console.WriteLine("*You can't heal while a Life Reflection is present* ");
                    string pause = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your healing is sucessful");
                    string pause = Console.ReadLine();
                }
            }
            else if(playerTurn == "9")
            {
                Console.WriteLine("Better luck next time. Round up some more heroes and try again!"); 
                SetHitPoints(0);
                playerTurn = "4";
            }
        }
    }
}
