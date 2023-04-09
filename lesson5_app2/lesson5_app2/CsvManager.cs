namespace lesson5_app2;

public static class CsvManager
{
    private const string Separator = "\"\\t\"";

    public static List<DirectoryItem> GetItemsFromCsv(string pathToCsv)
    {
        var items = new List<DirectoryItem>();
        var csv = File.ReadAllLines(pathToCsv);

        foreach (var line in csv)
        {
            var tempStr = line.Split(Separator);
            if (tempStr.Length != 3)

            {
                throw new FileLoadException($"Файл поврежден");
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
                    throw new FileLoadException($"Файл поврежден");
            }
            items.Add(new DirectoryItem(tempType, tempStr[1], Convert.ToDateTime(tempStr[2].Trim('"'))));
        }
        return items;
    }
}