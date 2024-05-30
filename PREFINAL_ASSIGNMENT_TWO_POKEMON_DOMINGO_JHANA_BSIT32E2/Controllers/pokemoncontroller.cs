using Microsoft.AspNetCore.Mvc;
using PokemonApp.Models;
using System.Collections.Generic;

namespace PokemonApp.Controllers
{
    public class PokemonController : Controller
    {
        public IActionResult Index()
        {
            var pokemon = new Pokemon
            {
                Name = "Pikachu",
                Moves = new List<string> { "Thunderbolt", "Quick Attack", "Iron Tail" },
                Abilities = new List<string> { "Static", "Lightning Rod" }
            };

            return View(pokemon);
        }
    }
}
