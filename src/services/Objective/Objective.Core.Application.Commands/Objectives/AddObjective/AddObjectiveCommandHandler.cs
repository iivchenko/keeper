using System;

using Objective.Core.Application.Commands.Common;
using Objective.Core.Domain.Objectives;

using TheObjective = Objective.Core.Domain.Objectives.Objective;

namespace Objective.Core.Application.Commands.Objectives.AddObjective
{
    public sealed class AddObjectiveCommandHandler : ICommandHandler<AddObjectiveCommand>
    {
        private readonly IObjectiveRepository _objeciveRepository;

        public AddObjectiveCommandHandler(IObjectiveRepository objeciveRepository)
        {
            if (objeciveRepository == null)
            {
                throw new ArgumentNullException(nameof(objeciveRepository));
            }

            _objeciveRepository = objeciveRepository;
        }

        public void Handle(AddObjectiveCommand command)
        {
            var objective = new TheObjective
            (
                Guid.NewGuid(),
                command.Name, 
                command.UserId,
                command.MilestoneId
            );

            _objeciveRepository.Create(objective);
        }
    }
}