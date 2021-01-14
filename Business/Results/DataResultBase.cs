namespace Business.Results
{
    public class DataResultBase<T> : IDataResult<T>
    {
        public T Data { get; }
        public string Message { get; }
        public bool IsSuccessful { get; }
        public DataResultBase(string message, bool isSuccessful, T data)
        {
            Message = message;
            IsSuccessful = isSuccessful;
            Data = data;
        }

        public DataResultBase(bool isSuccessful, T data)
        {
            IsSuccessful = isSuccessful;
            Data = data;
        }
    }
}
