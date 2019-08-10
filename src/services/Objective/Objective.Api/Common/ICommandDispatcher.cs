using  Objective.Core.Application.Commands.Common;

namespace Objective.Api.Common
{
    public interface ICommandDispatcher
    {
        void Dispatch(ICommand command);
    }
}