using Nancy;
 
namespace WebApplication
{
    public class GamesModule : NancyModule
    {
        public GamesModule(IGamesService gamesService)
        {
            Get("/games", args => gamesService.GetAll());
        }
    }
}