using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameApi.PlayedGames
{
 public class HomeModule : NancyModule
{
    public HomeModule()
    {
        Get("/", args => "Hello World, it's Nancy on .NET Core, Updated Again ");
    }
}
}
