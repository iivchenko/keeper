using FluentValidation;

namespace Objective.Core.Application.Queries.Objectives.GetObjectives
{
    class GetObjectivesQueryValidator : AbstractValidator<GetObjectivesQuery>
    {
        public GetObjectivesQueryValidator()
        {
            RuleFor(x => x.Skip).GreaterThanOrEqualTo(0);
            RuleFor(x => x.Take).GreaterThan(0);
        }
    }
}
