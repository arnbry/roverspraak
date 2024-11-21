using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace roverspraak.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoverSpraakController : ControllerBase
    {
        private static readonly string[] Aliases = new[]
{
            "Petter Smart",
            "Sorte Petter",
            "Magica Fra Tryll",
            "Spøkelseskladden",
            "Guffen Gås",
            "Fetter Anton",
            "Donald Duck",
            "Ole",
            "Dole",
            "Doffen"
        };

        private static readonly string[] Messages = new[]
        {
            "elle",
            "melle",
            "deg fortelle",
            "rygg i rann",
            "to i spann",
            "snipp snapp",
            "snute",
            "du er ute",
            "på ei silkepute",
        };

        private readonly ILogger<RoverSpraakController> _logger;

        public RoverSpraakController(ILogger<RoverSpraakController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetRoverSpraak")]
        public IEnumerable<RoverSpraak> Get()
        {
            return Enumerable.Range(1, 8).Select(index => new RoverSpraak
            {
                Id = Guid.NewGuid().ToString(),
                Created = DateOnly.FromDateTime(DateTime.Now.AddHours(index)),
                Alias = Aliases[Random.Shared.Next(Aliases.Length)],
                OriginalText = Messages[Random.Shared.Next(Messages.Length)]

            })
            .ToArray();
        }
    }
}
