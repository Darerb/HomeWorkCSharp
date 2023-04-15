namespace lesson6_app1;

public static class FileManager
{
    public static List<DirectoryItem> GetDirectoryContents(string dirName)
    {
        var content = new List<DirectoryItem>();
        var directories = Directory.GetDirectories(dirName);

        foreach (var directory in directories)
        {
            content.Add(new DirectoryItem(
                DirectoryItem.ItemTypes.Directory,
                directory.Remove(0, dirName.Length + 1),
                Directory.GetLastWriteTime(dirName)));
        }
        return content;
    }

    public static async Task ForceRecordToNewFile(string filePath, string content)
    {
        if (File.Exists(filePath))
        {
            File.Delete(filePath);
            Console.WriteLine($"Удален существующий файл");
        }

        await using var writer = new StreamWriter(filePath);
        await writer.WriteAsync(content);
    }
}
