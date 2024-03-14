using Tupy.Common.Responses;

namespace Tupy.Common.Extensions.Responses
{
    public static class ResponseExtensions
    {
        public static IExecutionResponse ToExecutionResponse(this IResponse self)
        {
            IExecutionResponse result = new ExecutionResponse(self.IsSuccess, self.ReasonPhrase);
            return result;
        }

        public static SingleResponse<T> ToSingleResponse<T>(this IExecutionResponse self)
        {
            SingleResponse<T> result = new SingleResponse<T>(self.IsSuccess, self.ReasonPhrase)
            {
                Exception = self.Exception,
                Validations = self.Validations
            };
            return result;
        }

        public static ListResponse<T> CreateListResponse<T>(this IExecutionResponse self)
        {
            ListResponse<T> result = new ListResponse<T>(self.IsSuccess, self.ReasonPhrase)
            {
                Exception = self.Exception,
                Validations = self.Validations
            };
            return result;
        }
    }
}
