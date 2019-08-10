using MediatR;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Objective.Core.Application.Commands.Objectives.AddObjective;
using System.Threading.Tasks;
using AutoMapper;

namespace Objective.Api.Objectives
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjectivesController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public ObjectivesController(
            IMediator mediator,
            IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<ObjectiveModel> GetObjectives()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public IEnumerable<ObjectiveModel> GetObjective(Guid id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public Task<Guid> AddObjective(ObjectiveAddModel objective)
        {
            return _mediator.Send(_mapper.Map<AddObjectiveCommand>(objective));
        }
    }
}
