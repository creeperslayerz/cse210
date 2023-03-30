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
            Kydra kydra = new Kydra(350, 1, 1, 1, 2);
            
            while(kydra.GetHitPoints() > 0)
            {
                kydra.KydraStats();
                kydra.BossTurn();

                kydra.KydraStats();
                kydra.PlayerTurn();

                

            }
        }

    }

    //When you construct Anubis: Set hitPoints to 140, Stamina to 0, and all energies to 0.
}