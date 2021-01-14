namespace Business.Results
{
    public class ErrorResult : ResultBase
    {
        public ErrorResult(string message) : base(false, message) { }
        public ErrorResult() : base(false) { }
    }
}
