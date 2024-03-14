namespace Tupy.Common.Responses
{
    public interface IResponse
    {
        bool IsSuccess { get; set; }
        string ReasonPhrase { get; set; }
    }
}
