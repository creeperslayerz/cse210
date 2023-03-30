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
                kydra.BossStats();
                kydra.BossTurn();

                kydra.BossStats();
                kydra.PlayerTurn();
            }
        }
        else if(bossChoice == "2")
        {
            Anubis anubis = new Anubis(140,0,0,0,0);

            while(anubis.GetHitPoints() > 0)
            {
                anubis.BossStats();
                anubis.BossTurn();

                anubis.BossStats();
                anubis.BossTurn();
            }
        }
        else
        {
            Console.WriteLine("May your tavern visits lead to many more adventures!");
        }
    }
}