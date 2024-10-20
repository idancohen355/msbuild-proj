using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the JSON configuration file
	    string configContent = File.ReadAllText("../../config/config.json");
            JObject config = JObject.Parse(configContent);

            // Get the greeting message from the JSON file
            string message = config["greeting"].ToString();
            Console.WriteLine(message);
        }
    }
}
