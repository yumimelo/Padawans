using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Padawans
{
    class albu
    {
        [JsonProperty("userId")]
        public int userId { get; set; }
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("title")]
        public string title { get; set; }
    }
}
