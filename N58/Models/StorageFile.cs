namespace N58Home.Api.Models;

public class StorageFile : IStorageEntriy
{
    public string Name { get; set; }

    public string Path { get; set; }

    public StorageEntryType EntryType { get; set; }

    public string? DirectoryPath { get; set; }

    public long Size { get; set; }

    public string Extension { get; set; }
}