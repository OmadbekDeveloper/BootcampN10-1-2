using N56.Models;

namespace N56.Service;

internal class FolderService
{
    private string _absolutePath;

    public void Execute(string appFolder, string storage)
    {
        _absolutePath = Path.Combine(appFolder, storage);

        if (Directory.Exists(_absolutePath))
            return;

        var folder = Directory.CreateDirectory(_absolutePath);
    }

    public string CreateFolder(User user) =>
        Directory.CreateDirectory(Path.Combine(CreateFolderType(typeof(User).Name), user.Id.ToString())).FullName;

    public string CreateFolder(string path, string folderName) =>
        Directory.CreateDirectory(Path.Combine(CreateFolderType(path), folderName)).FullName;

    private string CreateFolderType(string folderName)
    {
        var path = Path.Combine(_absolutePath, folderName);
        if (Directory.Exists(path))
            return path;

        Directory.CreateDirectory(path);
        return path;
    }
}