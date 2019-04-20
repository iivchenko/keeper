using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Objective.Api.Commands.Common;
using Objective.Core.Application.Commands.Objectives.AddObjective;

namespace Objective.Api.Commands.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjectivesController : ControllerBase
    {
        private readonly ICommandDispatcher _commandDispatcher;

        public ObjectivesController(ICommandDispatcher commandDispatcher)
        {
            _commandDispatcher = commandDispatcher;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult<string> AddObjective([FromBody] AddObjectiveDto addObjectiveDto)
        {
            var command = new AddObjectiveCommand
            {
                Name = addObjectiveDto.Name,
                UserId = addObjectiveDto.UserId,
                MilestoneId = addObjectiveDto.MilestoneId
            };

            _commandDispatcher.Dispatch(command);
            
            return Ok();
        }
    }
}
