/* GUNDAM STRIKER

Ein kleines Round-Based Text Command Fighting Game :D */

//Eigenschaften zum einbauen: „Angriff“, „Item“, „HP“, „Skill“, „Bot“, „Runde“

//Namensvergabe

Console.WriteLine ("Hello new Pilot, what's your Name?");

string? PlayerName = Console.ReadLine();

if (String.IsNullOrWhiteSpace (PlayerName))
{
    Console.WriteLine ("No problem you will be Pilot X then.");
}
else
{
    Console.WriteLine ($" {PlayerName} nice to meet you.");
}

//Player Basic Stats
int Health = 100;
int AttackPower = 10;
int Defense = 10;

//Tutorial Encounter
Console.WriteLine ($"{PlayerName} here is a little training course for ya.");

int TutorialBotHealth = 50;
int TutorialBotAttackPower = 2;
int TutorialBotDefense = 2; 

while (TutorialBotHealth > 0 && Health > 0)
