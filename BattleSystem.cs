class BattleSystem
{
    public static void StartBattle(Character player, Character enemy)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\n{enemy.Name} shows up");

        while (player.Health > 0 && enemy.Health > 0)
        {
            // Spieler greift an
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n{player.Name} turn!");
            int playerDamage = player.CalculateDamage() - enemy.Defense; //Damage Berechnung
            playerDamage = Math.Max(1, playerDamage);//Schaden immer mind. 1
            enemy.Health -= playerDamage; //Damage wird abgezogen von MaxHealth
            if (enemy.Health <= 0) //Falls gegner besiegt alternative Message + break aus dem Loop
            {
                Console.WriteLine($"{player.Name} attacks for {playerDamage} damage! The enemy is vanquished");
                break;
            }
            else
            Console.WriteLine($"{player.Name} attacks for {playerDamage} damage! {enemy.Name} has {enemy.Health} Life left.");

            Thread.Sleep (2000);

            // Gegner greift an (Funktionen fast wie bei "Spieler greift an")
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"\n{enemy.Name} turn!");
            int enemyDamage = enemy.CalculateDamage() - player.Defense;
            enemyDamage = Math.Max(1, enemyDamage); 
            player.Health -= enemyDamage;
            Console.WriteLine($"{enemy.Name} attacks for {enemyDamage} damage! {player.Name} has {player.Health} Life left.");

            Thread.Sleep (2000);
        }

        Console.ForegroundColor = ConsoleColor.Green;
        if (player.Health <= 0)
            Console.WriteLine($"\n{player.Name} lost the fight ...");
        else
            Console.WriteLine($"\n{enemy.Name} was defeated!");
            player.ResetStats();//Player Life wird auf Max resettet
    }
}
