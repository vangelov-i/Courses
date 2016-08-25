namespace ExtractingSongTitlesXml
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Xml;
    using System.Xml.Linq;
    using System.Xml.XPath;

    public class ExtraxtingSongTitles
    {
        public static void Main()
        {
            string path = "../../Catalogue.xml";

            //ReadWithXmlReader(path);
            ReadWithXDocument(path);
        }

        private static void ReadWithXDocument(string path)
        {
            XDocument doc = XDocument.Load(path);
            var titles = doc
                .XPathSelectElements("/catalogue/album/song/title")
                .Select(e => e.Value);

            Console.WriteLine(string.Join("\r\n", titles));
        }

        private static void ReadWithXmlReader(string path)
        {
            using (var reader = XmlReader.Create("../../Catalogue.xml"))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element &&
                        reader.Name == "title")
                    {
                        Console.WriteLine(reader.ReadInnerXml());
                    }
                }
            }
        }
    }
}
