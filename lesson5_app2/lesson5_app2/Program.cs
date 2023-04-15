namespace lesson5_app2;

static class lesson5_app2
{
    private static readonly string PathToDesiredFile = Environment.ExpandEnvironmentVariables(@"%AppData%/Lesson12Homework.txt");

    static void Main()
    {
        string pathToCsvFile;
        try
        {
            pathToCsvFile = File.ReadAllText(PathToDesiredFile);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Файл не найден");
            throw;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        List<DirectoryItem> contentList;
        try
        {
            contentList = CsvManager.GetItemsFromCsv(pathToCsvFile);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        Console.WriteLine($"{"Тип",2} {"Название",20} {"Дата изменения",40}");
        foreach (var item in contentList.OrderBy(x => x.DateLastChange))
        {
            Console.WriteLine($"{item.Type,2} {item.Name,4} {item.DateLastChange,40}");
        }
    }
}
