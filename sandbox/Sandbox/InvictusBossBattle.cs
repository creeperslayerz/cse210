public class InvictusBossBattle
{
    public InvictusBossBattle()
    {
        MainMenu();
    }
    public void MainMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Welcome brave, and foolish, team!");
        Console.WriteLine("1. Kydra (3 headed cousin of the Hydra)");
        Console.WriteLine("2. Anubis (God of Judgement where your actions become tangible reflections)");
        Console.Write("Which Boss would you like to defeat you? ");
        string bossChoice = Console.ReadLine();
        if(bossChoice == "1")
        {
            Kydra kydra = new Kydra(350, 1, 1, 1, 1);
            // int prismaEnergy = kydra.GetPrismaEnergy();
            // int greenHeadHP = kydra.GetGreenHeadHP();
            // int lifeEnergy = kydra.GetLifeEnergy();
            // int redHeadHP = kydra.GetRedHeadHP();
            // int fireEnergy = kydra.GetFireEnergy();
            // int blueHeadHP = kydra.GetBlueHeadHP();
            // int purpleEnergy = kydra.GetPurpleEnergy();
            // int aquaEnergy = kydra.GetAquaEnergy();
            // string lastHeadAttacked = kydra.GetLastHeadAttacked();
            // int hitPoints = kydra.GetHitPoints();
            
            while(kydra.GetHitPoints() > 0)
            {
                kydra.KydraStats();

                kydra.PlayerTurn();

                kydra.BossTurn();

            }
        }

    }

    //When you construct Anubis: Set hitPoints to 140, Stamina to 0, and all energies to 0.
}