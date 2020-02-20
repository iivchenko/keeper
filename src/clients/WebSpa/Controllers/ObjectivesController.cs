using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebSpa.Controllers
{
    public class ObjectiveModel
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }

    [Route("api/objectives")]
    [ApiController]
    public class ObjectivesController : ControllerBase
    {
        [HttpGet]
        public async Task<IEnumerable<ObjectiveModel>> GetObjectives([FromQuery] int skip, [FromQuery] int take)
        {
            return new List<ObjectiveModel>
            {
                new ObjectiveModel
                {
                    Name = "hello",
                    Description = "Test des"
                }
            };
        }
    }
}