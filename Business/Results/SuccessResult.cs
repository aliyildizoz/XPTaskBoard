namespace Business.Results
{
    public class SuccessResult : ResultBase
    {
        public SuccessResult(string message) : base(true, message) { }
        public SuccessResult() : base(true) { }
    }
}
