using System;

using  Objective.Core.Application.Commands.Common;

namespace Objective.Api.Common
{
    public sealed class CommandDispatcher : ICommandDispatcher
    {
        private readonly IServiceProvider _serviceProvider;

        public CommandDispatcher(IServiceProvider serviceProvider)
        {
            if (serviceProvider == null)
            {
                throw new ArgumentNullException(nameof(serviceProvider));
            }

            _serviceProvider = serviceProvider;
        }

        public void  Dispatch(ICommand command)
        {
            Type type = typeof(ICommandHandler<>);
            Type[] args = { command.GetType() };
            Type typeHandler = type.MakeGenericType(type);

            dynamic handler = _serviceProvider.GetService(typeHandler);

            handler.Handle((dynamic)command);   
        }
    }
}