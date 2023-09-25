
using System.Data.SqlClient;

namespace hellooop1
{
    public class Database
    {
        private static Database instance = null;

        private SqlConnection connection = new SqlConnection();

        private Database()
        {
            Console.WriteLine($"Inside Database() constructor");

      
            Console.WriteLine("\n> Config section:");
            var section = Config.getInstance().section();
            foreach (var item in section)
                Console.WriteLine($"{item.Key} - {item.Value}");
        }

        public static Database getInstance()
        {
            if (instance == null)
            {
                instance = new Database();
            }

            return instance;
        }

    }
}

