using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

using Objective.Core.Domain.Objectives;
using Objective.Core.Domain.Common;

namespace Objective.Core.Application.Commands.Objectives.AddObjective
{
    public sealed class AddObjectiveCommandHandler : IRequestHandler<AddObjectiveCommand, Guid>
    {
        private readonly IObjectiveFactory _objectiveFactory;
        private readonly IObjectiveRepository _objectiveRepository;
        private readonly IUnitOfWork _unitOfWork;

        public AddObjectiveCommandHandler(
            IObjectiveFactory objectiveFactory,
            IObjectiveRepository objectiveRepository,
            IUnitOfWork unitOfWork)
        {
            _objectiveFactory = objectiveFactory ?? throw new ArgumentNullException(nameof(objectiveFactory));
            _objectiveRepository = objectiveRepository ?? throw new ArgumentNullException(nameof(objectiveRepository));
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        public async Task<Guid> Handle(AddObjectiveCommand request, CancellationToken cancellationToken)
        {
            var objective = _objectiveFactory.Create(request.Name, request.Description);

            await _objectiveRepository.Create(objective);
            await _unitOfWork.Commit();

            return objective.Reference;
        }
    }
}