using System;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

// Import namespaces


namespace read_text
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                // Get config settings from AppSettings
                IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
                IConfigurationRoot configuration = builder.Build();
                string cogSvcEndpoint = configuration["CognitiveServicesEndpoint"];
                string cogSvcKey = configuration["CognitiveServiceKey"];

                // Authenticate Azure AI Vision client
                


                // Menu for text reading functions
                Console.WriteLine("\n1: Use Read API for image (Lincoln.jpg)\n2: Read handwriting (Note.jpg)\nAny other key to quit\n");
                Console.WriteLine("Enter a number:");
                string command = Console.ReadLine();
                string imageFile;

                switch (command)
                {
                    case "1":
                        imageFile = "images/Lincoln.jpg";
                        GetTextRead(imageFile, cvClient);
                        break;
                    case "2":
                        imageFile = "images/Note.jpg";
                        GetTextRead(imageFile, cvClient);
                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void GetTextRead(string imageFile, VisionServiceOptions serviceOptions)
        {
            // Use Analyze image function to read text in image


        }
    }
}
