using FluentValidation;

namespace Objective.Core.Application.Commands.Objectives.AddObjective
{
    public sealed class AddObjectiveValidator : AbstractValidator<AddObjectiveCommand>
    {
        public AddObjectiveValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .MaximumLength(50);
        }
    }
}
