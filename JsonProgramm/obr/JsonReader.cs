using JsonProgramm.Data;
using System.Security.Cryptography;
using System.Reflection;
using System.Reflection.Metadata;

namespace JsonProgramm.obr
{
    public class JsonReader
    {
        public async void JsonReaderMethod(string filePath) 
        {
            SerDis serDis = new SerDis();
            Crypt crypt = new Crypt();
            Hash hash = new Hash();
            JsonCreator creator = new JsonCreator();

            var jsonData = serDis.GetT<JsonData>(filePath); //Передача пути файла обработке дисериализации

            //Type type = typeof(JsonData);
            Type type = typeof(JsonDataString);
            //Рефлексия к данными массива

            using (Aes aes = Aes.Create())
            {
                    for (int i = 0; i < jsonData.jsonDataStrings.Length; i++)
                    {
                    foreach (MethodInfo methodinfo in type.GetMethods())//Определение метода, под которым подразумиваются данные.
                    {
                        if (methodinfo.ReturnType == typeof(string))//Реакция на данны типа "String"
                        {
                            byte[] enc = crypt.Encrypterd(i.ToString(), aes.Key, aes.IV);//Чтение и передача данных для шифорвания
                            serDis.SetT(i);
                        }
                        else if (methodinfo.ReturnType == typeof(int))//Реакиця на данные типа "int"
                        {
                            byte[] hsh = hash.HachMethod(i);//Чтение и передача данных для хеширования
                            serDis.SetT(i.ToString());
                        }
                        else//Реакция на данные типов "bool", "byte" и иных - отсутсвует.
                        {
                        }
                    }
                    JsonCreator.JsonCreatorMethod(aes.Key, aes.IV);//Вызов метода создания файла и передача ему ключа и вектора.
                }
            }
            //Серилизация открытой библиотеки
            //D:\Users\PC_PRO\Desktop\Card.json
        }
    }
}
