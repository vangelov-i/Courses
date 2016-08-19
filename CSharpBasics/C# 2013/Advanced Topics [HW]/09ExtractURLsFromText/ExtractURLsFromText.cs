using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that extracts and prints all URLs from given text. 
//URL can be in only two formats:

//•	http://something, e.g. http://softuni.bg, http://forums.softuni.bg, http://www.nakov.com 
//•	www.something.domain, e.g. www.nakov.com, www.softuni.bg, www.google.com

//Examples:

//Input	                                                            Output

//The site nakov.com can be access from http://nakov.com or         http://nakov.com  
//www.nakov.com. It has subdomains like mail.nakov.com and          www.nakov.com
//svetlin.nakov.com. Please check http://blog.nakov.com for         http://blog.nakov.com
//more information.	                                                

class ExtractURLsFromText
{
    static void Main(string[] args)
    {

        string[] input = Console.ReadLine().Split(' ');

        string http = "http://";
        string www = "www.";
        List<string> urls = new List<string>();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i][0] == 'w' && input[i][1] == 'w' && input[i][2] == 'w' && input[i][3] == '.')
            {
                if (!Char.IsLetter(input[i][input[i].Length -1]))
                {
                    www = input[i];
                    www = www.Remove(www.Length - 1);
                    urls.Add(www);
                }
                else
                {
                    www = input[i];
                    urls.Add(www);
                }
            }
            else if (input[i][0] == 'h' && input[i][1] == 't' && input[i][2] == 't' && input[i][3] == 'p'  && input[i][4] == ':' && input[i][5] == '/' && input[i][6] == '/')
            {
                if (!Char.IsLetter(input[i][input[i].Length -1]))
                {
                    http = input[i];
                    http = http.Remove(http.Length - 1);
                    urls.Add(http);
                }
                else
                {
                    http = input[i];
                    urls.Add(http);
                }
            }
        }

        foreach (var address in urls)
        {
            Console.WriteLine(address);
        }

    }
}