using MediatR;

namespace Shared.CQRS;

interface IQuery<out TResponse> : IRequest<TResponse> where TResponse : notnull
{
}