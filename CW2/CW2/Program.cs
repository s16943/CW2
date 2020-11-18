using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace CW2
{
    class Program
    {
        static void Main(string[] args)
        {
            var defCSV = args.Length > 0 ? args[0] : "dane.csv";
            var defResult = args.Length > 1 ? args[1] : "result.xml";
            var defFormat = "xml";

            var serial = new Serializer
            {
                author = "s16943"
            };

            List<Student> studentlist = new List<Student>();

            try
            {
                if (!File.Exists(defCSV))
                {
                    throw new FileNotFoundException("Plik nie istnieje", defCSV);
                }

                var lines = File.ReadAllLines(defCSV);
                foreach (var line in lines)
                {
                    String[] studentsArray = line.Split(", ");

                    if (studentsArray.Length != 9)
                    {
                        File.AppendAllText("Log.txt", $"{DateTime.UtcNow}  Wartośc niezgodna z wymaganiami {line}");
                        continue;
                    }
                    foreach (var argument in studentsArray)
                    {
                        if (argument.Length == 0)
                        {
                            File.AppendAllText("Log.txt", $"{DateTime.UtcNow} Pusta wartość! {line}");
                            break;
                        }
                    }
                    Student student = new Student
                    {
                        firstname =     studentsArray[0],
                        surname =       studentsArray[1],
                        index =         studentsArray[4],
                        birthdate =     studentsArray[5],
                        email =         studentsArray[6],
                        mother_name =   studentsArray[7],
                        father_name =   studentsArray[8],


                        studies = new Studies
                        {
                            name = studentsArray[2],
                            type = studentsArray[3]
                        }
                    };
                    serial.studentsList.Add(student);
                }

                if (defResult == "xml")
                {
                    using var writer = new FileStream($"{defResult}.{defFormat}", FileMode.Create);
                    var serializer = new XmlSerializer(typeof(Serializer));
                    serializer.Serialize(writer, serial);
                }
                if (defResult == "json")
                {
                    var jsonString = JsonSerializer.Serialize(serial);
                    File.AppendAllText("Data\result.json", jsonString);
                }
            }
            catch (FileNotFoundException e)
            {
                File.AppendAllText("log.txt", $"{DateTime.UtcNow}+{e.Message}+{e.FileName}\n");
            }
        }
    }
}
