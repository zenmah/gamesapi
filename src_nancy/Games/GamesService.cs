using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
 
namespace WebApplication
{
    public class Game
    {
        public int id {get; set;}
        public string name {get; set;}
        public string author {get; set;}
        public int release_year {get;set;}
    }
 
    public interface IGamesService
    {
        List<Game> GetAll();
    }
 
    public class GamesService : IGamesService
    {
        public  List<Game> GetAll()
        {
            List<Game> games = new List<Game>();
            games.Add(new Game{
              id = 0,
              name = "Apocalypse World",
              author = "Vincent Baker"
            });
            return games;
        }
    }
}