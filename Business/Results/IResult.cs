namespace Business.Results
{
    public interface IResult
    {
        bool IsSuccessful { get; }
        string Message { get; }
    }
}
