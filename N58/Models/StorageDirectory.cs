namespace N58Home.Api.Models;

public class StorageDirectory : IStorageEntriy
{
    public string Name { get; set; }

    public string Path { get; set; }

    public StorageEntryType EntryType { get; set; }

    public long ItemsCount { get; set; }
}