class BattleSystem
{
    public static void StartBattle(Character player, Character enemy)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\n{enemy.Name} taucht auf!");

        while (player.Health > 0 && enemy.Health > 0)
        {
            // Spieler greift an
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n{player.Name} ist am Zug!");
            int playerDamage = player.CalculateDamage() - enemy.Defense;
            playerDamage = Math.Max(1, playerDamage);
            enemy.Health -= playerDamage;
            Console.WriteLine($"{player.Name} greift an und verursacht {playerDamage} Schaden! {enemy.Name} hat noch {enemy.Health} Leben.");

            if (enemy.Health <= 0) break;

            // Gegner greift an
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"\n{enemy.Name} ist am Zug!");
            int enemyDamage = enemy.CalculateDamage() - player.Defense;
            enemyDamage = Math.Max(1, enemyDamage);
            player.Health -= enemyDamage;
            Console.WriteLine($"{enemy.Name} greift an und verursacht {enemyDamage} Schaden! {player.Name} hat noch {player.Health} Leben.");
        }

        Console.ForegroundColor = ConsoleColor.Yellow;
        if (player.Health <= 0)
            Console.WriteLine($"\n{player.Name} wurde besiegt...");
        else
            Console.WriteLine($"\n{enemy.Name} wurde besiegt!");
    }
}
