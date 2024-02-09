using Newtonsoft.Json;

namespace JsonProgramm.Data
{
    public class JsonData
    {
        [JsonProperty("cards")]
        public JsonDataString[] jsonDataStrings { get; set; }
    }
    public class JsonDataString
    {
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("family")]
        public string family { get; set; }
        [JsonProperty("cvc")]
        public int cvc { get; set; }
        [JsonProperty("month_of_issue")]
        public string month_of_issue { get; set; }
        [JsonProperty("year_of_issue")]
        public string year_of_issue { get; set; }
        [JsonProperty("numberCard")]
        public string numberCard { get; set; }
    }
}
