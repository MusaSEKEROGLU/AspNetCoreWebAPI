
namespace Backend.Shared.Utilities.Results
{
    public interface IResult
    {
        bool IsSuccess { get; }

        string Message { get; }
    }
}
