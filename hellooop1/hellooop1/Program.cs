
using System;

namespace hellooop1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Entering Main()");

            Opdracht2();
            Opdracht3();
            Opdracht4();
            Opdracht5();
            Opdracht6();
            Opdracht7();
            Console.WriteLine("\nExiting Main()");

        }

        private static void Opdracht2()
        {
            Console.WriteLine("\nOpdracht 2");

            
            Game game = new Game("games_table"); 
            var record = game.find(2); 

            Console.WriteLine("\n> Record found:");
            if (record.Value != null)
            {
                var key = record.Key; 

               
                var value = (GameRecord)record.Value; 

              
                Console.WriteLine($"[{key}] {value.Id} | {value.Name} | {value.PublisherId}"); 
            }
            else
            {
                Console.WriteLine($"Record does not exist");
            }

          
            var games = game.getTableData();

            Console.WriteLine("\n> Games table:");
            foreach (var item in games)
            {
                var key = item.Key;

                
                var value = (GameRecord)item.Value; 
                Console.WriteLine($"[{key}] {value.Id} | {value.Name} | {value.PublisherId}");
            }
        }

        private static void Opdracht3()
        {
            Console.WriteLine("\nOpdracht 3");

           
            Publisher publisher = new Publisher("publishers_table");
            var record = publisher.find(1);

         
            Console.WriteLine("\n> Record found:");
            if (record.Value != null)
            {
                var key = record.Key;

               
                var value = (PublisherRecord)record.Value;
                Console.WriteLine($"[{key}] {value.Id} - {value.Name}");
            }
            else
            {
                Console.WriteLine($"Record does not exist");
            }

            
            var publishers = publisher.getTableData();

            Console.WriteLine("\n> Publisher table:");
            foreach (var item in publishers)
            {
                var key = item.Key; 

             
                var value = (PublisherRecord)item.Value;
                Console.WriteLine($"[{key}] {value.Id} - {value.Name}");
            }

            
        }

        private static void Opdracht4()
        {
            Console.WriteLine("\nOpdracht 4");

            Config config = Config.getInstance();

            
            var section = Config.getInstance().section();
            var pw = Config.getInstance().item("password");

            
            Console.WriteLine("\n> Config section:");
            foreach (var item in section)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            
            Console.WriteLine("> Config item:");
            if (pw.Value != null)
            {
                var key = pw.Key;
                var value = pw.Value;
                Console.WriteLine($"[{key}] {value}");
            }
            else
            {
                Console.WriteLine($"Record does not exist");
            }

            
            Database database = Database.getInstance();
        }

        
        private static void Opdracht5()
        {
            Console.WriteLine("\nOpdracht 5");

            
            Game game = new Game("games_table");
            Publisher publisher = new Publisher("publisher_table");

           
            game.find(1);
            publisher.find(1);

           
            var game_name = game.Name;
            Console.WriteLine($"\n> Game name (before): {game_name}");

            var publisher_name = publisher.Name;
            Console.WriteLine($"> Publisher name (before): {publisher_name}");

            
            game.Name += " updated"; 
            game_name = game.Name;
            Console.WriteLine($"\n> Game name (after): {game_name}");

            publisher.Name += " updated";
            publisher_name = publisher.Name;
            Console.WriteLine($"> Publisher name (after): {publisher_name}");

           
            var game_publisher_id = game.PublisherId;
            Console.WriteLine($"\n> Game PublisherID (before): {game_publisher_id}");

           
            game.PublisherId += 100;
            game_publisher_id = game.PublisherId;
            Console.WriteLine($"> Game PublisherID (after): {game_publisher_id}");
        }

        private static void Opdracht6()
        {
            Console.WriteLine("\nOpdracht 6");

            
            Game game = new Game("games_table");
            var record = game.find(1);

           
            if (record.Value != null)
            {
                var game_publisher_name = game.publisher().Name;
                Console.WriteLine($"\n> Game {game.Name} is published by {game_publisher_name}");
            }
            else
            {
                Console.WriteLine($"Record does not exist");
            }
        }
        private static void Opdracht7()
        {
            Console.WriteLine("\nOpdracht 7");

            // haal alle game objecten op
            Game game = new Game("games");
            var games_objects = game.getDataObjects();

            // toon de naam van elke game, maak gebruik van de Name property
            Console.WriteLine("\n> Games (from object list):");
            foreach (var game_obj in games_objects)
            {
                Console.WriteLine($"{game_obj.Name}");
            }

            var publisher = new Publisher("publishers");
            var publisher_id = 1;
            publisher.find(publisher_id); 

            


            var games = publisher.games();


            Console.WriteLine("\nopdracht 7c :");
            Console.WriteLine($"games met publisher id {publisher_id}:");


            if (games.Count > 0)
            {
                foreach (var item in games)
                {
                    Console.WriteLine($"> {item.Name} | {item.PublisherId}");
                }
                    
            }
            else
            {
                Console.WriteLine("geen games gevonden");
            }
            
                
        }
    }
}
