namespace Business.Results
{
    public interface IDataResult<T> : IResult
    {
        T Data { get; }
    }
}
