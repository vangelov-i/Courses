namespace Extract_Artist_with_DOM
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    public class ArtistsExtractor
    {
        public static void Main()
        {
            XmlDocument doc = new XmlDataDocument();
            doc.Load("../../Catalogue.xml");
            //doc.Load("../../CheapCatalogue.xml");

            var catalogue = doc.DocumentElement;

            //ExtractArtistsUsingDOM(catalogue);
            ExtractArtistsUsingXPath(catalogue);
            //DeleteAlbumsWithPriceGreaterThan(catalogue, 20);

            //doc.Save("../../CheapCatalogue.xml");
        }

        private static void DeleteAlbumsWithPriceGreaterThan(XmlElement catalogue, int price)
        {
            var albums = catalogue.ChildNodes;
            var albumsToRemove = new List<XmlNode>();
            foreach (XmlNode album in albums)
            {
                var currenAlbumPrice = double.Parse(album.SelectSingleNode("price").InnerText);
                if (currenAlbumPrice > price)
                {
                    albumsToRemove.Add(album);
                    //catalogue.RemoveChild(album);
                }
            }

            foreach (XmlNode album in albumsToRemove)
            {
                catalogue.RemoveChild(album);
            }
        }

        private static void ExtractArtistsUsingDOM(XmlElement catalogue)
        {
            var albums = catalogue.ChildNodes;

            var artistsAlbumsCount = new Dictionary<string, int>();

            foreach (XmlNode album in albums)
            {
                string artist = album.SelectSingleNode("artist").InnerText;

                bool artistExists = artistsAlbumsCount.ContainsKey(artist);
                if (!artistExists)
                {
                    artistsAlbumsCount.Add(artist, 0);
                }

                artistsAlbumsCount[artist]++;
            }

            foreach (var artistAlbumsCount in artistsAlbumsCount)
            {
                string artist = artistAlbumsCount.Key;
                int albumsCound = artistAlbumsCount.Value;
                Console.WriteLine("Artist: {0} | Albums: {1} ", artist, albumsCound);
            }
        }

        private static void ExtractArtistsUsingXPath(XmlElement catalogue)
        {
            var xPathQuery = "/catalogue/album/artist";
            var artists = catalogue.SelectNodes(xPathQuery);

            var artistsAlbumsCount = new Dictionary<string, int>();

            foreach (XmlNode artistNode in artists)
            {
                string artistStr = artistNode.InnerText;

                bool artistExists = artistsAlbumsCount.ContainsKey(artistStr);
                if (!artistExists)
                {
                    artistsAlbumsCount.Add(artistStr, 0);
                }

                artistsAlbumsCount[artistStr]++;
            }

            foreach (var artistAlbumsCount in artistsAlbumsCount)
            {
                string artist = artistAlbumsCount.Key;
                int albumsCound = artistAlbumsCount.Value;
                Console.WriteLine("Artist: {0} | Albums: {1} ", artist, albumsCound);
            }
        }
    }
}
