using System;
using System.Collections.Generic;

namespace Tupy.Common.Responses
{
    public interface IExecutionResponse : IResponse
    {
        Exception Exception { get; set; }
        List<string> Validations { get; set; }
    }
}
