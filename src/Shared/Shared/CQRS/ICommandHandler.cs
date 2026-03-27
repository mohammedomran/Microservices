using MediatR;

namespace Shared.CQRS;

public interface ICommandHandler<in TRequest> : IRequestHandler<TRequest, Unit>
    where TRequest : ICommand
{
}

public interface ICommandHandler<in TRequest, out TResponse> : IRequestHandler<TRequest, TResponse>
    where TRequest : ICommand<TResponse>
    where TResponse : notnull
{
}