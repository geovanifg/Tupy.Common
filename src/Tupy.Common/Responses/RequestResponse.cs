namespace Tupy.Common.Responses
{
    public class RequestResponse : ResponseBase
    {
        public int StatusCode { get; set; }

        public RequestResponse() : base()
        {
            StatusCode = 0;
        }

        public RequestResponse(int statusCode, string reasonPhrase) : base(false, reasonPhrase)
        {
            StatusCode = statusCode;
        }
    }
}
