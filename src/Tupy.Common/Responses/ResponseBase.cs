namespace Tupy.Common.Responses
{
    public abstract class ResponseBase : IResponse
    {
        public bool IsSuccess { get; set; }
        public string ReasonPhrase { get; set; }

        public ResponseBase()
        {
            IsSuccess = true;
        }

        public ResponseBase(string reasonPhrase)
        {
            IsSuccess = false;
            ReasonPhrase = reasonPhrase;
        }

        public ResponseBase(bool isSucess, string reasonPhrase)
        {
            IsSuccess = isSucess;
            ReasonPhrase = reasonPhrase;
        }
    }
}
