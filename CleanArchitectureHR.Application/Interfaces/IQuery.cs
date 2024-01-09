using MediatR;


namespace CleanArchitectureHR.Application.Interfaces
{
    public interface IQuery<out TResult> : IRequest<TResult>
    {

    }
}
