
using System.Configuration;

namespace hellooop1
{
    public class Config
    {
        private static Config instance = null;

        private Dictionary<string, string> contents = new Dictionary<string, string>();

        private Config()
        {
            Console.WriteLine($"Inside Config() constructor");

            
            string key = "driver";

            string value = ConfigurationManager.AppSettings.Get(key);

            contents.Add(key, value);

            contents.Add("host", ConfigurationManager.AppSettings.Get("host"));
            contents.Add("port", ConfigurationManager.AppSettings.Get("port"));
            contents.Add("database", ConfigurationManager.AppSettings.Get("database"));
            contents.Add("username", ConfigurationManager.AppSettings.Get("username"));
            contents.Add("password", ConfigurationManager.AppSettings.Get("password"));

      
        }

        
        public static Config getInstance()
        {
            if (instance == null)
            {
                instance = new Config();
            }

            return instance;
        }

    
        public Dictionary<string, string> section()
        {
            return contents;
        }

      
        public KeyValuePair<string, string> item(string key)
        {
            KeyValuePair<string, string> record = default; 

            if (contents.ContainsKey(key))
            {
                var value = contents[key]; 
                record = new KeyValuePair<string, string>(key, value);
            }

            return record;
        }

    }
}

