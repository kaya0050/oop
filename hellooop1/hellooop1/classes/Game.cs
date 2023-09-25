

namespace hellooop1
{
    
    public class GameRecord : ModelRecord
    {
        
        public string Description { get; set; }
        public int Rating { get; set; }
        public int PublisherId { get; set; } 
    }

    
    public class Game : Model
    {
       
        public int PublisherId {
            get {
                return ((GameRecord)record.Value).PublisherId;
            }
            set {
                ((GameRecord)record.Value).PublisherId = value;
            }
        }

     
        public Game(string tablename) : base(tablename)
        {
            Console.WriteLine($"Inside Game() constructor");

           
            table_data.Add(1, new GameRecord { Id = 1, Name = "yokai watch", Description = "", Rating = 6, PublisherId = 1 });
            table_data.Add(2, new GameRecord { Id = 2, Name = "inazuma eleven", Description = "", Rating = 6, PublisherId = 1 });
            table_data.Add(3, new GameRecord { Id = 3, Name = "zelda", Description = "", Rating = 12, PublisherId = 2 });
        }

        
        public Publisher publisher()
        {
            Console.WriteLine($"Inside Game.publisher()");

          
            Publisher publisher = new Publisher("publishers");
            publisher.find(PublisherId);

           
            return publisher;
        }

        public List<Game> getDataObjects()
        {
            Console.WriteLine($"Inside Game.getDataObjects()");

            
            List<Game> games_objects = new List<Game>();

        
            Dictionary<int, object> games_records = getTableData();

            
            foreach (var game_rec in games_records)
            {
          
                Game game_obj = new Game("games");

          
                game_obj.setRecord(game_rec);

          
                games_objects.Add(game_obj);
            }

          
            return games_objects;
        }
    }
}
