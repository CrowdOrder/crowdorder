using Newtonsoft.Json;

namespace CrowdOrder.beta.Data
{
    public class EmailTemplateData
    {

        [JsonProperty("h1")]
        public string H1 { get; set; }

        [JsonProperty("maintext")]
        public string MainText { get; set; }

        [JsonProperty("buttontext")]
        public string ButtonText { get; set; }

        [JsonProperty("buttonurl")]
        public string ButtonUrl { get; set; }

        [JsonProperty("greeting")]
        public string Greeting { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }
        [JsonProperty("body2")]
        public string Body2 { get; set; }
        [JsonProperty("greeting2")]
        public string Greeting2 { get; set; }
    }
}
