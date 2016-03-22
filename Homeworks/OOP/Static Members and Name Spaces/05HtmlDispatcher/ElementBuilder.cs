using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05HtmlDispatcher
{
    class ElementBuilder
    {
        private string name;
        private string content = string.Empty;
        private Dictionary<string, string> attributes = new Dictionary<string, string>();

        public ElementBuilder(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public void AddAttributes(string attribute, string value)
        {
            this.attributes.Add(attribute, value);
        }

        public void AddContent(string content)
        {
            this.content = content;
        }

        public static string operator * (ElementBuilder item, int times)
        {
            string temp = string.Empty;
            for (int i = 0; i < times; i++)
            {
                temp += item.ToString();
            }
            return temp;
        }


        public override string ToString()
        {
            string temp = string.Empty;
            for (int i = 0; i < attributes.Count; i++)
            {
                temp += string.Format(" {0}=\"{1}\"", attributes.Keys.ElementAt(i), attributes.Values.ElementAt(i));
            }
            return string.Format
                (
                "<{0}{1}>{2}</{0}>", this.name, temp, content
                );
        }
    }
}
