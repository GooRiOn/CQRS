using CQRS.Contracts;
using CQRS.Domain.Interfaces;
using CQRS.Infrastructure.Interfaces.Contracts;

namespace CQRS.Domain.CommandHandlers
{
    abstract class CommandHandlerBase<TCommand> : ICommandHandler<TCommand>
        where TCommand : class, ICommand
    {
        IStaticCommandValidator<TCommand> CommandValidator { get; }

        protected CommandHandlerBase(IStaticCommandValidator<TCommand> commandValidator)
        {
            CommandValidator = commandValidator;
        }

        ICommandHandlerResult ICommandHandler<TCommand>.Handle(TCommand command)
        {
            var staticValidationResult = CommandValidator.ValidateStatic(command);

            if (staticValidationResult.HasError)
                return Error(staticValidationResult);

            return OnHandle(command);
        }

        static ICommandHandlerResult Error(IStaticValidationResult result)
        {
            return new CommandHandlerResult { ErrorMessage = result.ErrorMessage };
        }

        protected static ICommandHandlerResult Ok()
        {
            return new CommandHandlerResult { ErrorMessage = null };
        }

        protected static ICommandHandlerResult Error(string errorMessage)
        {
            return new CommandHandlerResult { ErrorMessage = errorMessage };
        }

        protected abstract ICommandHandlerResult OnHandle(TCommand command);
    }
}
