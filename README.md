Gundam Striker ist ein kleines, rundenbasiertes Text-Command-Fighting Game.
Der Spieler übernimmt die Rolle eines Gundam-Piloten und kämpft gegen feindliche Roboter in der Konsole.
Das Spiel nutzt ASCII Art für Gundams und Titelscreens und baut auf einem leider sehr einfachen Battle-System auf.

Features:

>Pilot-Namenswahl

>Anzeige von ASCII-Art Titelscreen und Gundam

>Rundenbasierter Kampf (Attacke, Verteidigung, Schadenberechnung)

>Zufällige Schadensvariationen

>ASCII-Art aus externen .txt Dateien ladbar

>Farbige Konsolenausgabe für verschiedene Events

//Verzeichniserklärung

ProjectGundamStriker/
├── Assets/                    # ASCII Art Dateien
│   ├── GundamArt.txt
│   ├── GundamStrikerTitel.txt
│   ├── TheEnd.txt
│
├── HelpSystems/                # Hilfsklassen (Struktur und Logik)
│   ├── AsciiArtLoader.cs       # ASCII-Art Ladefunktion
│   ├── BattleSystem.cs         # Kampfsystem
│   ├── Character.cs            # Charakterklasse
│
├── .gitignore                  # Git Ignore Regeln
├── Program.cs                  # Hauptlogik (Spielstart, Main Methode)
├── ProjectGundamStriker.csproj  # Projektdatei für .NET
├── README.md                   # Projektbeschreibung und Anleitungen