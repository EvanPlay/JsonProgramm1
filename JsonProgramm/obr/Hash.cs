using System.Security.Cryptography;
using System.Text;

namespace JsonProgramm.obr
{
    public class Hash
    {
        public byte[] HachMethod(int cvc)//Хеширование принятого кода cvc
        {
            byte[] hash = Encoding.UTF8.GetBytes(cvc.ToString());
            return SHA256.HashData(hash);
        }
    }
}
