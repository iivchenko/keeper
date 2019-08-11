using FluentValidation;

namespace Objective.Core.Application.Queries.Objectives.GetObjective
{
    public sealed class GetObjectiveQueryValidator : AbstractValidator<GetObjectiveQuery>
    {
        public GetObjectiveQueryValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty();
        }
    }
}
