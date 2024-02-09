using JsonProgramm.obr;

Searcher searcher = new Searcher();
JsonReader jsonReader = new JsonReader();

while (true)
{
    Console.WriteLine("Я программа, которой нужен JSON файл. Пожалуйста впишите абсолютный путь к JSON файлу.");
    Console.WriteLine("");

    var filePath = Console.ReadLine();
    Console.WriteLine("");

    if(searcher.SearhcerMethod(filePath))
        //Вызов обработки корректности файла из введённого пути.
    {
        jsonReader.JsonReaderMethod(filePath);
    }
}
    
