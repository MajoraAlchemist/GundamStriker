static class AsciiArtLoader //Kleine Funktion um AsciiArt aus txt zu laden
{
    public static string LoadArt(string filePath)
    {
        if (File.Exists(filePath))
        {
            return File.ReadAllText(filePath);
        }
        else
        {
            return "[ASCII Art not found]";
        }
    }
}