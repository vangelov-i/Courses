namespace WriteDirectoryToXml
{
    using System;
    using System.IO;
    using System.Xml;
    using System.Xml.Linq;

    public class WriteDirectoryToXml
    {
        public static void Main()
        {
            var directoryPath = @"C:\Users\Iliyan\Desktop\Dropbox\Databases";
            DirectoryInfo directory = new DirectoryInfo(directoryPath);

            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true
            };

            using (var xmlWriter = XmlWriter.Create("../../Directory.xml", settings))
            {
                
                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("directories");
                TraverseDirectory(directory, xmlWriter);
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
            }

            var rootDirectory = new XElement("Directories");
            XDocument doc = new XDocument();
            doc.Add(rootDirectory);

            TraverseDirectory(directory, rootDirectory);
            doc.Save("../../DirectoriesWithLINQ.xml");
        }

        private static void TraverseDirectory(DirectoryInfo directory, XElement xElement)
        {
            var currentDir = new XElement("dir", directory.Name);
            xElement.Add(currentDir);

            var childDirectories = directory.GetDirectories();
            foreach (var childDirectory in childDirectories)
            {
                TraverseDirectory(childDirectory, currentDir);
            }

            var files = directory.GetFiles();
            foreach (var fileInfo in files)
            {
                currentDir.Add(new XElement("file", fileInfo.Name));
            }
        }

        private static void TraverseDirectory(DirectoryInfo directory, XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("dir");
            xmlWriter.WriteValue(directory.Name);

            var childDirectories = directory.GetDirectories();
            foreach (var childDirectory in childDirectories)
            {
                TraverseDirectory(childDirectory, xmlWriter);
            }


            var files = directory.GetFiles();
            foreach (var fileInfo in files)
            {
                xmlWriter.WriteStartElement("file");
                xmlWriter.WriteValue(fileInfo.Name);
                xmlWriter.WriteEndElement();
            }

            xmlWriter.WriteEndElement();
        }
    }
}
