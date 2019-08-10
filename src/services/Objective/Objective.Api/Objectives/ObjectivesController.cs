using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Objective.Api.Objectives
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjectivesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public IEnumerable<ObjectiveModel> GetObjectives()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public IEnumerable<ObjectiveModel> GetObjective(Guid id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IEnumerable<ObjectiveModel> AddObjective(ObjectiveAddModel objective)
        {
            throw new NotImplementedException();
        }
    }
}
