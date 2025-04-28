/* GUNDAM STRIKER

Ein kleines Round-Based Text Command Fighting Game :D */

using System.IO; // Wichtig, damit File.ReadAllText funktioniert
using static System.Console; //Nutze "using static System.Console" um nicht jedes mal "console." zu schreiben

//Titelscreen
Clear();
Console.ForegroundColor = ConsoleColor.DarkRed;
string GundamStrikerTitle = AsciiArtLoader.LoadArt("Assets/GundamStrikerTitel.txt");
WriteLine($"{GundamStrikerTitle}");

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

Thread.Sleep (3000);

WriteLine ("Come with me i show you're new Machine, hope it's to your taste.");

Thread.Sleep (3500);
Clear();

//Lädt AsciiArt aus .txt und stellt sie in Rot da.
Console.ForegroundColor = ConsoleColor.DarkRed;
string GundamArt = AsciiArtLoader.LoadArt("Assets/GundamArt.txt");
WriteLine(GundamArt);

Thread.Sleep (3000);
//Tutorial Encounter
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine ($"{PlayerName} here is a little training course for ya.");

//Vergebe Variable in meiner Character class um sie ins BattleSystem einzufügen
Character player = new Character (PlayerName, 100, 30, 10);
var TutorialBot = new Character ("Tutorial-Bot", 50, 25, 10);

//Ruft BattleSystem auf und geht durch den Battle Loop
BattleSystem.StartBattle(player, TutorialBot);

WriteLine("Not bad, but here come's another, harder one"); 
var Striker01 = new Character("Striker01", 75, 27, 10);
BattleSystem.StartBattle(player, Striker01);

WriteLine("===Credits===");
WriteLine(">Titelscreen from https://www.asciiart.eu/text-to-ascii-art");
WriteLine(">Gundam Art from http://aa.en.utf8art.com/iconaa");
WriteLine(">Gundam Art formatting at https://www.asciiart.eu/image-to-ascii");

Thread.Sleep (3500);

//Endscreen
ForegroundColor = ConsoleColor.DarkMagenta;
string TheEnd = AsciiArtLoader.LoadArt("Assets/TheEnd.txt");
WriteLine(TheEnd);

Thread.Sleep(4000);

Environment.Exit(0);