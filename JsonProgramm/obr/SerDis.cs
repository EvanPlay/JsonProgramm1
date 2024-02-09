using JsonProgramm.Data;
using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace JsonProgramm.obr
{
    public class SerDis
    {
        public T GetT <T>(string filePath)//Дисерилизация файла
        {
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(filePath));
        }
        public void SetT <T>(T fileStream)//Серилизация файла
        {
            System.Text.Json.JsonSerializer.Serialize(fileStream);
        }
    }
}
