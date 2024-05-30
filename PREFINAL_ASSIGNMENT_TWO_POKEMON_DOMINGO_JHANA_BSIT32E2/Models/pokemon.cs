using System.Collections.Generic;

namespace PokemonApp.Models
{
    public class Pokemon
    {
        public string Name { get; set; }
        public List<string> Moves { get; set; }
        public List<string> Abilities { get; set; }

        public Pokemon()
        {
            Moves = new List<string>();
            Abilities = new List<string>();
        }
    }
}
