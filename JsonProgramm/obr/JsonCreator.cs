using System;
using System.IO;
using Newtonsoft.Json;
using JsonProgramm.Data;

namespace JsonProgramm.obr
{
    public class JsonCreator
    {
        public static void JsonCreatorMethod(byte[] Key, byte[] IV)
        {
            var obj = new JsonContent//Создание объекта-файла
            {
                Contents = new Contents[]//Создание заполняемой данными формы
                {
                    new Contents
                    {
                        Key = $"{Key}",
                        IV = $"{IV}"
                    }
                }
            };
            var json = JsonConvert.SerializeObject(obj, Formatting.Indented);//Сохранение и создание файла с данными
            var DescktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);//Полуение пути к рабочему столу
            File.WriteAllText(Path.Combine(DescktopPath), json);//Создание файла на рабочем столе (Необходим запуск от имени Администратора, для работы)
        }
    }
}
