namespace N55Home;

internal class FolderExamplesService
{
    public int GetFolderCount(string appFolder) =>
        Directory.GetDirectories(appFolder).Length;

    public int GetFileCount(string appFolder) =>
        Directory.GetFiles(appFolder).Length;

    public long GetFullSize(string appFolder) =>
        Directory.GetFiles(appFolder).Sum(size => new FileInfo(size).Length);

    public long GetMaxSize(string appFolder) =>
        Directory.GetFiles(appFolder).Max(size => new FileInfo(size).Length);
}