using N55Home;

//FolderExample.Execute();
var appFolder = Directory.GetCurrentDirectory();
Console.WriteLine(appFolder);
var fileService = new FolderExamplesService();

Console.WriteLine("Folderlar soni: " + fileService.GetFolderCount(appFolder));
Console.WriteLine("Filelar soni: " + fileService.GetFileCount(appFolder));
Console.WriteLine("Filelar hajmi: " + fileService.GetFullSize(appFolder));
Console.WriteLine("Eng katta fayl hajmi: " + fileService.GetMaxSize(appFolder));