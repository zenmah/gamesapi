using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameAPI.PlayedGames
{
    public class Game
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int ReleasedInYear { get; set; }
    }
}
