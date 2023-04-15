using System.IO.Compression;

namespace lesson5_app1;

static class lesson5_app1
{
    const string FileName = "archive.zip";
    const string UnzipDirectory = "archive";
    const string CsvName = "DirectoryItemsList.csv";
    const string Separator = @"\t";
    const string PathToFile = @"%AppData%\Lesson12Homework.txt";

    static void Unzip(string fileName, string unzipDirectory)
    {
        if (Directory.Exists(unzipDirectory))
        {
            Directory.Delete(unzipDirectory, true);
        }
        ZipFile.ExtractToDirectory(sourceArchiveFileName: fileName, destinationDirectoryName: unzipDirectory);
        Console.WriteLine($"Архив распакован");
    }

    static void Main()
    {
        try
        {
            Unzip(FileName, UnzipDirectory);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Данного архива нет");
            throw;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        List<DirectoryItem> directoryContent;
        try
        {
            directoryContent = FileManager.GetDirectoryContents(UnzipDirectory);
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine($"Папка не найдена");
            throw;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        try
        {
            CsvManager.RecordDirectoryContent(directoryItems: directoryContent, fileName: CsvName, separator: Separator);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        try
        {
            Directory.Delete(UnzipDirectory, true);
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine($"Папка уже удалена");
            throw;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        try
        {
            FileManager.ForceRecordToNewFile(filePath: Environment.ExpandEnvironmentVariables(PathToFile), content: Path.GetFullPath(CsvName));
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
