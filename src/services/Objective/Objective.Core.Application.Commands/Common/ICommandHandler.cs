namespace Objective.Core.Application.Commands.Common
{
    public interface ICommandHandler<TCommand> 
        where TCommand : class, ICommand
    {
        void Handle(TCommand command);
    }
}