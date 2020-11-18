using CW2.Data;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace CW2
{
    class Serializer
    {
        public HashSet<Student> studentsList { get; set; }

        [XmlAttribute(AttributeName = "Created at")]
        [JsonPropertyName("Created at")]
        public DateTime time { get; set; }

        [XmlAttribute(AttributeName = "Author")]
        [JsonPropertyName("Author")]
        public string author { get; set; }

        public Serializer()
        {
            studentsList = new HashSet<Student>(new StudentComparator());
            time = DateTime.UtcNow;
        }
    }
}
