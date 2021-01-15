namespace Business.Results
{
    public class ErrorDataResult<T> : DataResultBase<T> 
    {
        public ErrorDataResult(string message, T data) : base(message, false, data) { }
        public ErrorDataResult(T data) : base(false, data) { }
        public ErrorDataResult(string messsage) : base(false, default(T)) { }
        public ErrorDataResult() : base(null, false, default(T)) { }
    }
}
