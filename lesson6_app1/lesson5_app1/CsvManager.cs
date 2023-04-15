namespace lesson6_app1;

public static class CsvManager
{
    public static async Task RecordDirectoryContent(List<DirectoryItem> directoryItems, string fileName, string separator)
    {
        await using var writer = new StreamWriter(fileName);
        foreach (var directoryItem in directoryItems)
        {
            await writer.WriteLineAsync($"\"{directoryItem.Type}\"{separator}\"{directoryItem.Name}\"{separator}\"{directoryItem.DateLastChange}\"");
        }
    }
}
