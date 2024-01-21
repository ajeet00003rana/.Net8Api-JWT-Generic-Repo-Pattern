using System.Net;

namespace Project.Common.Api
{
    public class Response
    {
        public HttpStatusCode Status { get; set; }
        public string Message { get; set; }
    }
}
