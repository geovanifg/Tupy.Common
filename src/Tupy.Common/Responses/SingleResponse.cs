namespace Tupy.Common.Responses
{
    public class SingleResponse<T> : ExecutionResponse
    {
        public T Item { get; set; }

        public SingleResponse() : base()
        {
        }

        public SingleResponse(string reasonPhrase) : base(reasonPhrase)
        {

        }

        public SingleResponse(bool isSucess, string reasonPhrase) : base(isSucess, reasonPhrase)
        {
            IsSuccess = isSucess;
            ReasonPhrase = reasonPhrase;
        }

        public SingleResponse(T item) : base()
        {
            Item = item;
        }
    }
}
