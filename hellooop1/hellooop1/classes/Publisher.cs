

namespace hellooop1
{
    
    public class PublisherRecord : ModelRecord
    {
     
        public string Headquarters { get; set; }
        public string Website { get; set; }
    }

    
    public class Publisher : Model
    {
      
        public Publisher(string tablename) : base(tablename)
        {
            

           
            table_data.Add(1, new PublisherRecord { Id = 1, Name = "level5", Headquarters = "JP", Website = "www.level5.com" });
            table_data.Add(2, new PublisherRecord { Id = 2, Name = "nintendo", Headquarters = "JP", Website = "www.nintendo.com" });
            table_data.Add(3, new PublisherRecord { Id = 3, Name = "nintendo", Headquarters = "JP", Website = "www.nintendo.com" });
        }

        public List<Game> games()
        {

            var publisher_games = new List<Game>();


            Game game = new Game("games");
            var games_objects = game.getDataObjects();


            foreach (var game_obj in games_objects)
            {
                if (this.Id == game_obj.PublisherId)
                {
                    publisher_games.Add(game_obj);
                }
            }
            return publisher_games;
        }
        
    }
    
}
