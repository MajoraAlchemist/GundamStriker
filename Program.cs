/* GUNDAM STRIKER

Ein kleines Round-Based Text Command Fighting Game :D */
//Eigenschaften zum einbauen: „Angriff“, „Item“, „HP“, „Skill“, „Bot“, „Runde“

//Nutze "using static System.Console" um nicht jedes mal "console." zu schreiben
using System;
using System.Runtime.InteropServices;
using static System.Console;

//Titelscreen
Console.ForegroundColor = ConsoleColor.DarkRed;
WriteLine(@"

>>===================================================================<<
|| __      __       .__                                  __          ||
||/  \    /  \ ____ |  |   ____  ____   _____   ____   _/  |_  ____  ||
||\   \/\/   // __ \|  | _/ ___\/  _ \ /     \_/ __ \  \   __\/  _ \ ||
|| \        /\  ___/|  |_\  \__(  <_> )  Y Y  \  ___/   |  | (  <_> )||
||  \__/\  /  \___  >____/\___  >____/|__|_|  /\___  >  |__|  \____/ ||
||       \/       \/          \/            \/     \/                ||
||  ________                  .___                                   ||
|| /  _____/ __ __  ____    __| _/____    _____                      ||
||/   \  ___|  |  \/    \  / __ |\__  \  /     \                     ||
||\    \_\  \  |  /   |  \/ /_/ | / __ \|  Y Y  \                    ||
|| \______  /____/|___|  /\____ |(____  /__|_|  /                    ||
||        \/           \/      \/     \/      \/                     ||
||  _________ __         .__ __                ._.                   ||
|| /   _____//  |________|__|  | __ ___________| |                   ||
|| \_____  \\   __\_  __ \  |  |/ // __ \_  __ \ |                   ||
|| /        \|  |  |  | \/  |    <\  ___/|  | \/\|                   ||
||/_______  /|__|  |__|  |__|__|_ \\___  >__|   __                   ||
||        \/                     \/    \/       \/                   ||
>>===================================================================<<
");

Thread.Sleep (2000);


//Namensvergabe

Console.ForegroundColor = ConsoleColor.Green;
WriteLine ("Hello new Pilot, what's your Name?");

string? PlayerName = ReadLine();

if (String.IsNullOrWhiteSpace (PlayerName))
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    WriteLine ("No problem you will be Pilot X then.");
    PlayerName = "Pilot X";
}
else
{
    WriteLine ($"{PlayerName} nice to meet you.");
}

Thread.Sleep (2000);

//Player Basic Stats
int Health = 100;
int AttackPower = 10;
int Defense = 10;

//Tutorial Encounter
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine ($"{PlayerName} here is a little training course for ya.");

int TutorialBotHealth = 50;
int TutorialBotAttackPower = 2;
int TutorialBotDefense = 2; 

while (TutorialBotHealth > 0 && Health > 0);



WriteLine ("===Credits===");
WriteLine(">Titelscreen from https://www.asciiart.eu/text-to-ascii-art");