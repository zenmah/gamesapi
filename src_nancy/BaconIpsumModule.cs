using Nancy;
 
namespace WebApplication
{
    public class BaconIpsumModule : NancyModule
    {
        public BaconIpsumModule(IBaconIpsumService baconIpsumService)
        {
            Get("/", args => "Super Duper Happy Path running on .NET Core");
            Get("/test", args => "Test");
            Get("/baconipsum", async args => await baconIpsumService.GenerateAsync());
        }
    }
}