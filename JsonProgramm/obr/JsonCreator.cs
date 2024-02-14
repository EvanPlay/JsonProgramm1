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
            var key = Convert.ToHexString(Key);
            var iv = Convert.ToHexString(IV);
            var obj = new JsonContent//Создание объекта-файла
            {
                Contents = new Contents[]//Создание заполняемой данными формы
                {
                    new Contents
                    {
                        Key = $"{key}",
                        IV = $"{iv}"
                    }
                }
            };
            var json = JsonConvert.SerializeObject(obj, Formatting.Indented);//Сохранение и создание файла с данными
            //var DescktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);//Полуение пути к рабочему столу
                File.WriteAllText("JsonKeyFile.json", json);//Создание файла на рабочем столе (Необходим запуск от имени Администратора, для работы)
        }
    }
}
