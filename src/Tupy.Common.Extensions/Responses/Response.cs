using System;
using Tupy.Common.Responses;

namespace Tupy.Common.Extensions.Responses
{
    public static class Response
    {
        public static ExecutionResponse CreateExecutionResponse(Exception ex)
        {
            ExecutionResponse result = new ExecutionResponse(false, ex.Message)
            {
                Exception = ex
            };
            return result;
        }

        public static SingleResponse<T> CreateSingleResponse<T>(Exception ex)
        {
            SingleResponse<T> result = new SingleResponse<T>(false, ex.Message)
            {
                Exception = ex
            };
            return result;
        }

        public static ListResponse<T> CreateListResponse<T>(Exception ex)
        {
            ListResponse<T> result = new ListResponse<T>(false, ex.Message)
            {
                Exception = ex
            };
            return result;
        }
    }
}
