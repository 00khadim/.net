using System;
using System.Collections.Generic;
using BookStoreAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EquipeController : ControllerBase
    {
        private static List<Equipe> _equipes = new List<Equipe>
        {
            new Equipe { Id = 1, nomEquipe = "Ferrari", Nationality = "Italie", Pilote = new List<string> { "Leclerc", "Sainz" } },
            new Equipe { Id = 2, nomEquipe = "McLaren", Nationality = "Angleterre", Pilote = new List<string> { "Norris", "Piastri" } }
        };

        [HttpGet]
        public ActionResult<List<Equipe>> GetEquipes()
        {
            if (_equipes == null || _equipes.Count == 0)
            {
                return NotFound("Aucune équipe trouvée.");
            }

            return Ok(_equipes);
        }

        [HttpPost]
        public IActionResult CreateEquipe(Equipe equipe)
        {
            equipe.Id = _equipes.Count + 1;
            _equipes.Add(equipe);

            return CreatedAtAction(nameof(GetEquipes), new { id = equipe.Id }, equipe);
        }
    }
}
