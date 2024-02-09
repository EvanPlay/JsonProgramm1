using JsonProgramm.Data;
using System.Security.Cryptography;
using System.Reflection;

namespace JsonProgramm.obr
{
    public class JsonReader
    {
        public async void JsonReaderMethod(string filePath) 
        {
            SerDis serDis = new SerDis();
            Crypt crypt = new Crypt();
            Hash hash = new Hash();

            var jsonData = serDis.GetT<JsonData>(filePath); //Передача пути файла обработке дисериализации

            using (Aes aes = Aes.Create())
            {

                foreach (var item in jsonData.jsonDataStrings)
                {
                    //Добавить рефлексию для определения типов и/или имён файлов, для работы
                    if (item.cvc == null)//временные значения, добвленые для очистки списка ошибок. Требуется решение
                    {
                        hash.HachMethod(item.cvc);
                        serDis.SetT(item.cvc);
                    }
                    else//Добавить возможность пропуска несуществующих объектов в массиве
                    {
                        crypt.Encrypterd(item.ToString(), aes.Key, aes.IV);
                        string newData = item.ToString();
                        serDis.SetT(newData);
                    }
                }
            }
            //Серилизация открытой библиотеки
        }
    }
}
