using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace CW2
{
    class Studies
    {
        [XmlAttribute(AttributeName = "Name")]
        [JsonPropertyName("Name")]
        public string name { get; set; }

        [XmlAttribute(AttributeName = "Mode")]
        [JsonPropertyName("Mode")]
        public string type { get; set; }
    }

}
