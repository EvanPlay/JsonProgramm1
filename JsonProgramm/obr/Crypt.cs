using System.Security.Cryptography;
using Aes = System.Security.Cryptography.Aes;

namespace JsonProgramm.obr
{
    public class Crypt
    {
        public byte[] Encrypterd (string jsonData, byte[] Key, byte[] IV)//Передача данных, ключа и вектора
        {
            byte[] encData;
            using (Aes aes = Aes.Create())//Кодировка с использованием ранее переданных ключа и вектора.
            {
                aes.Key = Key;
                aes.IV = IV;
                using (MemoryStream memoryStream = new MemoryStream())//Использование памяти для хранения зашифрованного контента
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(aes.Key, aes.IV), CryptoStreamMode.Write))//Шифрование
                    {
                        using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
                        {
                            streamWriter.Write(jsonData);
                        }
                        encData = memoryStream.ToArray();
                    }
                }
                return encData;
            }
        }
    }
}
