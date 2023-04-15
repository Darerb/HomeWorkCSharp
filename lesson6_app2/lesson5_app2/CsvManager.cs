namespace lesson6_app2;

public static class CsvManager
{
    private const string Separator = "\"\\t\"";

    private static async Task<string> ReadCsv(string pathToCsv)
    {
        using var streamReader = new StreamReader(pathToCsv);
        var rawCsv = await streamReader.ReadToEndAsync();
        if (rawCsv == null)
        {
            throw new FileLoadException();
        }
        return rawCsv;
    }

    private static List<string> ParseLines(string? rawCsv)
    {
        var csv = new List<string>();

        csv.AddRange(rawCsv!.Split("\r\n"));
        csv.Remove(csv.Last());

        return csv;
    }

    public static async Task<List<DirectoryItem>> GetItemsFromCsv(string pathToCsv)

    {
        var csv = ParseLines(await ReadCsv(pathToCsv));

        var items = new List<DirectoryItem>();

        foreach (var line in csv)
        {
            var tempStr = line.Split(Separator);
            if (tempStr.Length != 3)

            {
                throw new FileLoadException($"Файл повреждён");
            }

            DirectoryItem.ItemTypes tempType;
            switch (tempStr[0].Trim('"'))
            {
                case "File":
                    tempType = DirectoryItem.ItemTypes.File;
                    break;
                case "Directory":
                    tempType = DirectoryItem.ItemTypes.Directory;
                    break;
                default:
                    throw new FileLoadException($"Файл повреждён.");
            }

            items.Add(new DirectoryItem(tempType, tempStr[1], Convert.ToDateTime(tempStr[2].Trim('"'))));
        }

        return items;
    }
}