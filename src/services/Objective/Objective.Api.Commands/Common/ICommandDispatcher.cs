using  Objective.Core.Application.Commands.Common;

namespace Objective.Api.Commands.Common
{
    public interface ICommandDispatcher
    {
        void Dispatch(ICommand command);
    }
}