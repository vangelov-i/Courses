namespace TransformTxtToXml
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Xml.Linq;

    public class ConvertTxtToXml
    {
        public static void Main()
        {
            string phonesTxtPath = "../../PhoneBook.txt";
            var phoneEntries = new List<string[]>();

            using (var fileReader = new StreamReader(phonesTxtPath))
            {
                string currentLine = fileReader.ReadLine();
                while (currentLine != null)
                {
                    var currentPhoneEntry = currentLine
                        .Split(new[] { ','}, StringSplitOptions.RemoveEmptyEntries);
                    phoneEntries.Add(currentPhoneEntry);
                    currentLine = fileReader.ReadLine();
                }
            }

            var people = phoneEntries
                .Select(e => new
                {
                    Name = e[0].Trim(),
                    Address = e[1].Trim(),
                    PhoneNumber = e[2].Trim(),
                });

            var doc = new XDocument();
            var root = new XElement("PhoneBook");
            
            doc.Add(root);
            foreach (var person in people)
            {
                XAttribute idAttribute = new XAttribute("id", Guid.NewGuid());
                XElement name = new XElement("Name", person.Name);
                XElement address = new XElement("Address", person.Address);
                XElement phoneNumber = new XElement("PhoneNumber", person.PhoneNumber);
                XElement personElement = new XElement(
                    "Person", 
                    idAttribute, 
                    name, 
                    address, 
                    phoneNumber);
                root.Add(personElement);
            }

            doc.Save("../../PhoneBook.xml");
        }
    }
}
