using Autofac;
using CQRS.Contracts.AddProduct;
using CQRS.Contracts.AddProductQuantity;
using CQRS.Domain.CommandHandlers;
using CQRS.Domain.EventHandlers;
using CQRS.Domain.Interfaces;
using CQRS.Domain.Validation;

namespace CQRS.Domain.DependencyInjection
{
    public class Registration
    {
        public static void Register(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<CommandExecutor>().As<ICommandExecutor>();

            containerBuilder.RegisterType<EventExecutor>().As<IEventExecutor>();

            containerBuilder.RegisterType<EventEmitter>().As<IEventEmitter>().SingleInstance();

            containerBuilder.RegisterGeneric(typeof(NullStaticCommandValidator<>)).As(typeof(IStaticCommandValidator<>));

            containerBuilder.RegisterType<AddProductCommandHandler>()
                .As<ICommandHandler<AddProductCommand>>();

            containerBuilder.RegisterType<AddProductQuantityCommandHandler>()
                .As<ICommandHandler<AddProductQuantityCommand>>();            
        }
    }
}
