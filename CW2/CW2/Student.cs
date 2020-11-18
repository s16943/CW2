using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace CW2
{
    class Student
    {
        [XmlElement(elementName: "First name")]
        [JsonPropertyName("First name")]
        public string firstname { get; set; }

        [XmlElement(elementName: "Surname")]
        [JsonPropertyName("Surname")]
        public string surname { get; set; }

        [XmlElement(elementName: "Studies")]
        [JsonPropertyName("Studies")]
        public Studies studies { get; set; }

        [XmlElement(elementName: "Index")]
        [JsonPropertyName("Index")]
        public string index { get; set; }

        [XmlElement(elementName: "Birthday")]
        [JsonPropertyName("Birthday")]
        public string birthdate { get; set; }

        [XmlElement(elementName: "Email")]
        [JsonPropertyName("Email")]
        public string email { get; set; }

        [XmlElement(elementName: "Mothers name")]
        [JsonPropertyName("Mothers name")]
        public string mother_name { get; set; }

        [XmlElement(elementName: "Fathers name")]
        [JsonPropertyName("Mothers name")]
        public string father_name { get; set; }



    }
}
