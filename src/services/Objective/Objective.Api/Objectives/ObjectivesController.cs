using MediatR;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Objective.Core.Application.Commands.Objectives.AddObjective;
using System.Threading.Tasks;
using AutoMapper;
using Objective.Core.Application.Queries.Objectives.GetObjective;
using Objective.Core.Application.Queries.Objectives.GetObjectives;

namespace Objective.Api.Objectives
{
    [Route("api/objectives")]
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
        public async Task<IEnumerable<ObjectiveModel>> GetObjectives([FromQuery] int skip, [FromQuery] int take)
        {
            var objectives = await _mediator.Send(new GetObjectivesQuery { Skip = skip, Take = take });

            return _mapper.Map<IEnumerable<GetObjectivesQueryItem>, IEnumerable<ObjectiveModel>>(objectives.Objectives);
        }

        [HttpGet("{id}")]
        public async Task<ObjectiveModel> GetObjective(Guid id)
        {
            var objective = await _mediator.Send(new GetObjectiveQuery { Id = id });

            return _mapper.Map<GetObjectiveQueryResult, ObjectiveModel>(objective);
        }

        [HttpPost]
        public Task<Guid> AddObjective(ObjectiveAddModel objective)
        {
            return _mediator.Send(_mapper.Map<ObjectiveAddModel, AddObjectiveCommand>(objective));
        }
    }
}
