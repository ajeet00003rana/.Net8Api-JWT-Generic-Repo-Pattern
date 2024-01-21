using System.Net;
using System;

namespace Project.Common.Auth
{
    public class LoginModel
    {
        public string Username { get; set; }

        public string Password { get; set; }
    }

    public class AuthenticationResponse
    {
        public HttpStatusCode Status { get; set; }
        public string Message { get; set; }
        public string Token { get; set; }
        public DateTime? Expiration { get; set; }
    }
}
