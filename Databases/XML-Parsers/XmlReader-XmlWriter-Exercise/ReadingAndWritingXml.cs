namespace XmlReader_XmlWriter_Exercise
{
    using System.Collections.Generic;
    using System.Xml;
    using System.Xml.Linq;

    public class ReadingAndWritingXml
    {
        public static void Main()
        {
            string loadPath = "../../Catalogue.xml";

            var albumsArtists = GetAlbumsNamesAndArtists(loadPath);

            CreatAlbumsXml(albumsArtists);
        }

        private static Queue<string> GetAlbumsNamesAndArtists(string loadPath)
        {
            var result = new Queue<string>();

            using (var xmlReader = XmlReader.Create(loadPath))
            {
                while (xmlReader.Read())
                {
                    if (xmlReader.NodeType == XmlNodeType.Element &&
                        xmlReader.Name == "name")
                    {
                        string albumName = xmlReader.ReadInnerXml();
                        result.Enqueue(albumName);
                    }
                    else if (xmlReader.NodeType == XmlNodeType.Element &&
                            xmlReader.Name == "artist")
                    {
                        string artistName = xmlReader.ReadInnerXml();
                        result.Enqueue(artistName);
                    }
                }
            }

            return result;
        }

        private static void CreatAlbumsXml(Queue<string> albumsArtists)
        {
            XDocument albumsXml = new XDocument();
            var root = new XElement("Albums");
            albumsXml.Add(root);

            while (albumsArtists.Count > 0)
            {
                string artistName = albumsArtists.Dequeue();
                string albumName = albumsArtists.Dequeue();
                XElement name = new XElement("Name", albumName);
                XElement artist = new XElement("Artist", artistName);

                XElement album = new XElement("Album", name, artist);
                root.Add(album);
            }

            albumsXml.Save("../../Albums.xml");
        }
    }
}
