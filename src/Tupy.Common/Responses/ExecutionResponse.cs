
using System;
using System.Collections.Generic;

namespace Tupy.Common.Responses
{
    public class ExecutionResponse : ResponseBase, IExecutionResponse
    {
        public Exception Exception { get; set; }
        public List<string> Validations { get; set; }

        public ExecutionResponse() : base()
        {
        }

        public ExecutionResponse(string reasonPhrase) : base(reasonPhrase)
        {

        }

        public ExecutionResponse(bool isSucess, string reasonPhrase) : base(isSucess, reasonPhrase)
        {
            IsSuccess = isSucess;
            ReasonPhrase = reasonPhrase;
        }
    }
}
