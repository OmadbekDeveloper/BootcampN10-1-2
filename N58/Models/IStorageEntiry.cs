namespace N58Home.Api.Models;

public interface IStorageEntriy
{
    string Name { get; set; }

    string Path { get; set; }

    public StorageEntryType EntryType { get; set; }
}