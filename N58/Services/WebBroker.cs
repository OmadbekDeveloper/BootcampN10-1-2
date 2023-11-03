using N58Home.Api.Models;
using System.IO;

namespace N58Home.Api.Services;

public class WebBroker
{
    private readonly IWebHostEnvironment _environment;

    public WebBroker(IWebHostEnvironment environment)
    {
        _environment = environment;
    }

    public ValueTask<IEnumerable<StorageDirectory>> GetDirectories() =>
        new ValueTask<IEnumerable<StorageDirectory>>(Directory.EnumerateDirectories(_environment.WebRootPath, "*", SearchOption.AllDirectories)
            .Select(directory => new DirectoryInfo(directory))
            .Select(item => new StorageDirectory()
            {
                Name = item.Name,
                Path = item.FullName,
                EntryType = StorageEntryType.Directory,
                ItemsCount = item.EnumerateFileSystemInfos().Count(),
            }));

    public ValueTask<IEnumerable<StorageFile>> GetFiles() =>
        new ValueTask<IEnumerable<StorageFile>>(Directory.EnumerateFiles(_environment.WebRootPath, "*", SearchOption.AllDirectories)
            .Select(file => new FileInfo(file))
            .Select(item => new StorageFile()
            {
                Name = item.Name,
                Path = item.FullName,
                EntryType = StorageEntryType.File,
                DirectoryPath = item.DirectoryName,
                Size = item.Length,
                Extension = item.Extension,
            }));
}