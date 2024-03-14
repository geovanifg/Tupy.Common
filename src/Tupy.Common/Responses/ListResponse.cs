using System.Collections.Generic;

namespace Tupy.Common.Responses
{
    public class ListResponse<T> : ExecutionResponse
    {
        public IEnumerable<T> Items { get; set; }

        public ListResponse() : base()
        {
        }

        public ListResponse(string reasonPhrase) : base(reasonPhrase)
        {

        }

        public ListResponse(bool isSucess, string reasonPhrase) : base(isSucess, reasonPhrase)
        {
            IsSuccess = isSucess;
            ReasonPhrase = reasonPhrase;
        }

        public ListResponse(IEnumerable<T> items) : base()
        {
            Items = items;
        }
    }
}
