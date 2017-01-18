using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameAPI.PlayedGames;

namespace GameApi.PlayedGames
{
 public class PlayedGamesModule : NancyModule
{
    public PlayedGamesModule(IPlayedGames gameService)
    {
        Get("/playedgames", args => gameService.GetAll());
    }
}


    public interface IPlayedGames
    {
        List<Game> GetAll();
    }

    public class Playedgames: IPlayedGames
    {
        public List<Game> GetAll()
        {
            return new List<Game>
            {
                new Game
                {
                    id=0,
                    Name="Apocalypse World",
                    Author = "Vincent Baker",
                    ReleasedInYear = 2014
                }
            };


        }
    }


}
