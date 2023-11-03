namespace N55Home;

internal class FolderExample
{
    public static void Execute()
    {
        var appFoler = Directory.GetCurrentDirectory();
        var folderName = "Team";

        Directory.CreateDirectory(folderName);

        var entries = Directory.EnumerateFileSystemEntries(appFoler);
        entries.ToList().ForEach(Console.WriteLine);

        Console.WriteLine("\n\n");

        var folder = Directory.GetDirectories(appFoler);
        folder.ToList().ForEach(Console.WriteLine);

        Console.WriteLine("\n\n");

        var files = Directory.GetFiles(appFoler);
        files.ToList().ForEach(Console.WriteLine);
    }
}