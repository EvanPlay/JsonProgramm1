using JsonProgramm.Data;
using Newtonsoft.Json;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Text.Json.Serialization;

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
                    if (item.GetType() == typeof(int))
                    {
                        hash.HachMethod(item.cvc);
                    }
                    else
                    {
                        crypt.Encrypterd(item.ToString(), aes.Key, aes.IV);
                    }
                }
            }
            //Серилизация открытой библиотеки
        }
    }
}
