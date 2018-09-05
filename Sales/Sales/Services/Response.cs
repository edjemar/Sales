using System.Collections.Generic;

namespace Sales.Services
{
    public class Response
    {
        internal List<object> Result;

        public bool IsSuccess { get; internal set; }
        public string Message { get; internal set; }
    }
}