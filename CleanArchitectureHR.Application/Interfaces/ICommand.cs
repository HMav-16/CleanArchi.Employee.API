using MediatR;


namespace CleanArchitectureHR.Application.Interfaces
{
    public interface ICommand : IRequest
    {
    }

    public interface ICommand<out TResult> : IRequest<TResult>
    {
    }
}
