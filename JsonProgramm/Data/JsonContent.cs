using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonProgramm.Data
{
    public class JsonContent
    {
        [JsonProperty("Content")]
        public Contents[] Contents { get; set; }
    }
    public class Contents
    {
        [JsonProperty("Key")]
        public string Key { get; set; }
        [JsonProperty("IV")]
        public string IV { get; set; }
    }
}
